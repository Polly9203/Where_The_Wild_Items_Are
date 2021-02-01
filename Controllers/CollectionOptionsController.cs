using Where_The_Wild_Items_Are.Data;
using Where_The_Wild_Items_Are.Models;
using Where_The_Wild_Items_Are.Models.CollectionOptionsViewModels;
using Where_The_Wild_Items_Are.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Where_The_Wild_Items_Are.Controllers
{

    public class CollectionOptionsController : ManageController
    {
        private readonly UserManager<ApplicationUser> _ApplicationUserManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        private readonly UrlEncoder _urlEncoder;

        private const string AuthenticatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";
        private const string RecoveryCodesKey = nameof(RecoveryCodesKey);

        ApplicationDbContext db;

        public CollectionOptionsController(UserManager<ApplicationUser> ApplicationUserManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, IEmailSender emailSender, ILogger<ManageController> logger, UrlEncoder urlEncoder, ApplicationDbContext context) : base(ApplicationUserManager, signInManager, roleManager, emailSender, logger, urlEncoder, context)
        {
            _ApplicationUserManager = ApplicationUserManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _logger = logger;
            _urlEncoder = urlEncoder;
            db = context;
        }

        [HttpGet]
        public IActionResult CreateCollection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCollection(string caption, string tag, string annotation, string text)
        {
            Collection collection = new Collection(caption, annotation, tag, text, _ApplicationUserManager.GetUserId(User));
            db.Collections.Add(collection);
            //ApplicationUser ApplicationUser = db.Users.FirstOrDefault(p => p.Id == _UserManager.GetApplicationUserId(ApplicationUser));
            //ApplicationUser.Collections.Add(collection);
            //db.ApplicationUsers.Update(ApplicationUser);
            db.SaveChanges();
            return RedirectToAction("ViewAndEditCollection", new { id = collection.Id });
        }

        [HttpGet]
        public IActionResult ViewAndEditCollection(int id)
        {
            Collection collection = db.Collections.Include(p => p.Comments).FirstOrDefault(p => p.Id == id);
            if (_ApplicationUserManager.GetUserId(User) != collection.LinkToCreator)
            {
                return RedirectToAction("ViewCollection", new { id = id });
            }
            else
            {
                List<Comment> temporaryCollectionComments = new List<Comment>();
                if (collection.Comments.Count != 0)
                {
                    foreach (var comment in collection.Comments)
                    {
                        if (comment.ParentCommentId != 0)
                        {
                            comment.Text = db.Comments.FirstOrDefault(p => p.Id == comment.ParentCommentId).CreatorName + ", " + comment.Text;
                        }
                        temporaryCollectionComments.Add(comment);
                    }
                    return View(new ViewAndEditCollectionViewModel(collection, temporaryCollectionComments.OrderByDescending(s => s.CreationTime).ToList()));
                }
                else
                {
                    return View(new ViewAndEditCollectionViewModel(collection, null));
                }
            }
        }

        [HttpPost]
        public IActionResult ViewAndEditCollection(bool delete, string caption, string annotation, string text,
            int id, int like, bool messageExist, int parentId, string messageText, bool likeExist, int commentId, bool view)
        {
            Collection collection = db.Collections.Include(x => x.Comments).FirstOrDefault(p => p.Id == id);
            if (!delete)
            {
                if (!messageExist)
                {
                    if (view)
                    {
                        return RedirectToAction("ViewCollection", new { id = id });
                    }
                    else
                    {
                        if (likeExist)
                        {
                            Comment comment = db.Collections.FirstOrDefault(p => p.Id == id).Comments.FirstOrDefault(p => p.Id == commentId);
                            comment.Like++;
                            db.Comments.Update(comment);
                            db.Collections.Update(collection);
                            db.SaveChanges();
                            return RedirectToAction("ViewAndEditCollection", new { id = id });
                        }
                        else
                        {
                            collection.Caption = caption;
                            collection.Annotation = annotation;
                            collection.Like = like;
                            collection.Text = text;
                            collection.LastUpdateTime = DateTime.Now;
                            db.Update(collection);
                        }
                    }
                }
                else
                {
                    Comment comment = new Comment(_ApplicationUserManager.GetUserName(User), parentId, db.Collections.FirstOrDefault(p => p.Id == id),
                        messageText);
                    db.Comments.Add(comment);
                    db.Collections.Update(collection);
                    db.SaveChanges();
                    return RedirectToAction("ViewAndEditCollection", new { id = id });
                }
            }
           else
            {
                db.Remove(collection);
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ViewCollection(int id)
        {
            Collection collection = db.Collections.Include(x => x.Comments).FirstOrDefault(p => p.Id == id);
            List<Comment> temporaryCollectionComments = new List<Comment>();
            if (collection.Comments != null)
            {
                foreach (var comment in collection.Comments)
                {
                    if (comment.ParentCommentId != 0)
                    {
                        comment.Text = db.Comments.FirstOrDefault(p => p.Id == comment.ParentCommentId).CreatorName + ", " + comment.Text;
                    }
                    temporaryCollectionComments.Add(comment);
                }
                return View(new ViewAndEditCollectionViewModel(collection, temporaryCollectionComments.OrderByDescending(s => s.CreationTime).ToList()));
            }
            else
            {
                return View(new ViewAndEditCollectionViewModel(collection, null));
            }
        }

        [HttpPost]
        public IActionResult ViewCollection(int id, int like, bool messageExist, int parentId, string messageText, bool likeExist, int commentId)
        {
            Collection collection = db.Collections.Include(x => x.Comments).FirstOrDefault(p => p.Id == id);
            if (messageExist)
            {
                Comment comment = new Comment(_ApplicationUserManager.GetUserName(User), parentId, db.Collections.FirstOrDefault(p => p.Id == id),
                    messageText);
                db.Comments.Add(comment);
                db.Collections.Update(collection);
                db.SaveChanges();
                return RedirectToAction("ViewCollection", new { id = id });
            }
            else if (likeExist)
            {
                Comment comment = db.Collections.FirstOrDefault(p => p.Id == id).Comments.FirstOrDefault(p => p.Id == commentId);
                comment.Like++;
                db.Comments.Update(comment);
                db.Collections.Update(collection);
                db.SaveChanges();
                return RedirectToAction("ViewCollection ", new { id = id });
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
