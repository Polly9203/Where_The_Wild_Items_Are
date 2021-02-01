using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Where_The_Wild_Items_Are.Models;
using Where_The_Wild_Items_Are.Data;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace Where_The_Wild_Items_Are.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index(SortState sortOrder = SortState.LastUpdateTimeDescendingly)
        {
            IQueryable<Collection> collections = db.Collections;
            ViewData["CaptionSort"] = sortOrder == SortState.CaptionAscending ?
                SortState.CaptionDescendingly : SortState.CaptionAscending;
            ViewData["LastUpdateTimeSort"] = sortOrder == SortState.LastUpdateTimeAscending ?
                SortState.LastUpdateTimeDescendingly : SortState.LastUpdateTimeAscending;
            ViewData["LikeSort"] = sortOrder == SortState.LikeAscending ? SortState.LikeDescendingly : SortState.LikeAscending;
            ViewData["NumberOfItemSort"] = sortOrder == SortState.NumberOfItemAscending ?
               SortState.NumberOfItemDescendingly : SortState.NumberOfItemAscending;
            switch (sortOrder)
            {
                case SortState.CaptionAscending:
                    collections = collections.OrderBy(s => s.Caption);
                    break;
                case SortState.CaptionDescendingly:
                    collections = collections.OrderByDescending(s => s.Caption);
                    break;
                case SortState.LastUpdateTimeDescendingly:
                    collections = collections.OrderByDescending(s => s.LastUpdateTime);
                    break;
                case SortState.LikeAscending:
                    collections = collections.OrderBy(s => s.Like);
                    break;
                case SortState.LikeDescendingly:
                    collections = collections.OrderByDescending(s => s.Like);
                    break;
                case SortState.NumberOfItemAscending:
                    collections = collections.OrderBy(s => s.NumberOfItem);
                    break;
                case SortState.NumberOfItemDescendingly:
                    collections = collections.OrderByDescending(s => s.NumberOfItem);
                    break;
                default:
                    collections = collections.OrderBy(s => s.LastUpdateTime);
                    break;
            }
            return View(collections.AsNoTracking().ToList());
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [NonAction]
        public string GetCulture(string code = "")
        {
            if (!String.IsNullOrEmpty(code))
            {
                CultureInfo.CurrentCulture = new CultureInfo(code);
                CultureInfo.CurrentUICulture = new CultureInfo(code);
            }
            return $"CurrentCulture:{CultureInfo.CurrentCulture.Name}, CurrentUICulture:{CultureInfo.CurrentUICulture.Name}";
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
