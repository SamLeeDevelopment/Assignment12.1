#pragma checksum "D:\Advanced C#\Week 12\Assignment 12.1\Assignment 6.1\Views\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9141c29270d313b71d850f0ecd6f61b3c29e5232"
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
#line 1 "D:\Advanced C#\Week 12\Assignment 12.1\Assignment 6.1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Advanced C#\Week 12\Assignment 12.1\Assignment 6.1\Views\_ViewImports.cshtml"
using Assignment_6._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Advanced C#\Week 12\Assignment 12.1\Assignment 6.1\Views\_ViewImports.cshtml"
using Assignment_6._1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Advanced C#\Week 12\Assignment 12.1\Assignment 6.1\Views\_ViewImports.cshtml"
using Assignment_6._1.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Advanced C#\Week 12\Assignment 12.1\Assignment 6.1\Views\_ViewImports.cshtml"
using Assignment_6._1.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9141c29270d313b71d850f0ecd6f61b3c29e5232", @"/Views/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11b2aa13ec030713abf7dfc5e59af971e70f99e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Lockout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Advanced C#\Week 12\Assignment 12.1\Assignment 6.1\Views\Account\Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header>\n    <h1 class=\"text-danger\">Locked out.</h1>\n    <p class=\"text-danger\">This account has been locked out, please try again later.</p>\n</header>\n");
        }
        #pragma warning restore 1998
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
