#pragma checksum "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e33c32b97972ad922ceddbeaefd7fc2b1b28fe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogsByWriterProfile_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogsByWriterProfile/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e33c32b97972ad922ceddbeaefd7fc2b1b28fe2", @"/Views/Shared/Components/BlogsByWriterProfile/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e577ec8186a6180c55256e3394ed2437372d5f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogsByWriterProfile_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:700px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"social-feed-box\">\r\n\r\n        <div class=\"float-right social-action dropdown\">\r\n\r\n\r\n        </div>\r\n        <div class=\"social-avatar\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 249, "\"", 286, 2);
            WriteAttributeValue("", 256, "/Blog/BlogDetails/", 256, 18, true);
#nullable restore
#line 13 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml"
WriteAttributeValue("", 274, item.BlogID, 274, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"float-left\">\r\n                <strong>");
#nullable restore
#line 14 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml"
                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </a>\r\n\r\n            <br />\r\n            <small class=\"text-muted\">");
#nullable restore
#line 18 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml"
                                 Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n        </div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 493, "\"", 530, 2);
            WriteAttributeValue("", 500, "/Blog/BlogDetails/", 500, 18, true);
#nullable restore
#line 20 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml"
WriteAttributeValue("", 518, item.BlogID, 518, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"social-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e33c32b97972ad922ceddbeaefd7fc2b1b28fe26698", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 599, "~/BlogThumbnails/", 599, 17, true);
#nullable restore
#line 22 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml"
AddHtmlAttributeValue("", 616, item.BlogThumbnailImage, 616, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </a>\r\n \r\n\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\BlogsByWriterProfile\Default.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
