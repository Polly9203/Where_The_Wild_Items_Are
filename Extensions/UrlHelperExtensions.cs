using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Where_The_Wild_Items_Are.Controllers;

namespace Microsoft.AspNetCore.Mvc
{
    public static class UrlHelperExtensions
    {
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string ApplicationUserId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ConfirmEmail),
                controller: "Account",
                values: new { ApplicationUserId, code },
                protocol: scheme);
        }

        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string ApplicationUserId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ResetPassword),
                controller: "Account",
                values: new { ApplicationUserId, code },
                protocol: scheme);
        }
    }
}
