#pragma checksum "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Email\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d1578d2e09bca90a2fc3a4776e652ada687b7a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Email_ConfirmEmail), @"mvc.1.0.view", @"/Views/Email/ConfirmEmail.cshtml")]
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
#line 1 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\_ViewImports.cshtml"
using OgrenciBilgiPaylasimSistemi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\_ViewImports.cshtml"
using OgrenciBilgiPaylasimSistemi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1578d2e09bca90a2fc3a4776e652ada687b7a4", @"/Views/Email/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e577ec8186a6180c55256e3394ed2437372d5f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Email_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Email\ConfirmEmail.cshtml"
  
    Layout = null;
    ViewData["Title"] = "ConfirmEmail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Confirm Email</h1>\r\n<p>\r\n    Thank you for confirming your email.\r\n    <a href=\"/Login/Login\">Giriş Yap</a>\r\n</p>");
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
