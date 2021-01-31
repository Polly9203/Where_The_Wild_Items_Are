using Where_The_Wild_Items_Are.Data;
using Where_The_Wild_Items_Are.Models;
using Where_The_Wild_Items_Are.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Where_The_Wild_Items_Are.Controllers
{
    public class CreateNewCollectionController : ManageController
    {
        public CreateNewCollectionController(UserManager<ApplicationUser> ApplicationUserManager, SignInManager<ApplicationUser> signInManager,RoleManager<IdentityRole> roleManager, IEmailSender emailSender, ILogger<ManageController> logger, UrlEncoder urlEncoder, ApplicationDbContext context) : base(ApplicationUserManager, signInManager, roleManager, emailSender, logger, urlEncoder, context)
        {
        }

        [HttpGet]
        public IActionResult CreateNewCollection()
        {
            return View();
        }

    }
}
