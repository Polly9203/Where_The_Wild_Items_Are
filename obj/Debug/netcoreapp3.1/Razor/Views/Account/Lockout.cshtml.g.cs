#pragma checksum "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d07c45db63ebc1ae72a67d80919475a6c58f85d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Lockout), @"mvc.1.0.view", @"/Views/Account/Lockout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Where_The_Wild_Items_Are;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Where_The_Wild_Items_Are.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Where_The_Wild_Items_Are.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Where_The_Wild_Items_Are.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d07c45db63ebc1ae72a67d80919475a6c58f85d", @"/Views/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c40fa0f2230e36d6ada116afe029570e4c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Lockout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\Account\Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h2 class=\"text-danger\">");
#nullable restore
#line 6 "C:\Users\polin\Just_all\Programming\Itransition\Where_The_Wild_Items_Are\Views\Account\Lockout.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"text-danger\">This account has been locked out, please try again later.</p>\r\n</header>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
