#pragma checksum "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be3aa0b7adf81ef2d63dabe02a2bd5b547240824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_GetBlogsBySearch), @"mvc.1.0.view", @"/Views/Blog/GetBlogsBySearch.cshtml")]
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
#line 1 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be3aa0b7adf81ef2d63dabe02a2bd5b547240824", @"/Views/Blog/GetBlogsBySearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e577ec8186a6180c55256e3394ed2437372d5f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_GetBlogsBySearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"
  
    ViewData["Title"] = "GetBlogsBySearch";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"wrapper wrapper-content animated fadeInRight\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"ibox \">\r\n                <div class=\"ibox-content\">\r\n                    <h2>\r\n                        ");
#nullable restore
#line 17 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"
                   Write(ViewBag.blogCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" adet sonuç bulundu\r\n                    </h2>\r\n");
#nullable restore
#line 19 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"hr-line-dashed\"></div>\r\n                        <div class=\"search-result\">\r\n                            <h3><a");
            BeginWriteAttribute("href", " href=\"", 664, "\"", 701, 2);
            WriteAttributeValue("", 671, "/Blog/BlogDetails/", 671, 18, true);
#nullable restore
#line 22 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"
WriteAttributeValue("", 689, item.BlogID, 689, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"
                                                                    Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 759, "\"", 796, 2);
            WriteAttributeValue("", 766, "/Blog/BlogDetails/", 766, 18, true);
#nullable restore
#line 23 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"
WriteAttributeValue("", 784, item.BlogID, 784, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"search-link\">");
#nullable restore
#line 23 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"
                                                                                    Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                          \r\n                        </div>\r\n");
#nullable restore
#line 26 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Blog\GetBlogsBySearch.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n         \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
