#pragma checksum "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\GetLastCommentsByWriter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7290b38043b206d276c94b0490b35185e8f5290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetLastCommentsByWriter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GetLastCommentsByWriter/Default.cshtml")]
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
#line 1 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\GetLastCommentsByWriter\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7290b38043b206d276c94b0490b35185e8f5290", @"/Views/Shared/Components/GetLastCommentsByWriter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e577ec8186a6180c55256e3394ed2437372d5f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetLastCommentsByWriter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""ibox "">
        <div class=""ibox-title"">
            <h5>Yapılan Son Yorumlar</h5>
            <div class=""ibox-tools"">
                <a class=""collapse-link"">
                    <i class=""fa fa-chevron-up""></i>
                </a>
                <a class=""close-link"">
                    <i class=""fa fa-times""></i>
                </a>
            </div>
        </div>
        <div class=""ibox-content"">

            <div class=""row"">
                <div class=""col-lg-12"">
                    <table class=""table table-hover margin bottom"">
                        <thead>
                            <tr>
                                <th style=""width: 1%"" class=""text-center"">Başlık</th>
                               
                                <th class=""text-center"">Yorum İçeriği</th>
                                <th class=""text-center"">Tarih</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 30 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\GetLastCommentsByWriter\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    \r\n                                    <td>\r\n                                        ");
#nullable restore
#line 35 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\GetLastCommentsByWriter\Default.cshtml"
                                   Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center small\"> ");
#nullable restore
#line 37 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\GetLastCommentsByWriter\Default.cshtml"
                                                              Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\"><span class=\"label label-primary\">");
#nullable restore
#line 38 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\GetLastCommentsByWriter\Default.cshtml"
                                                                                          Write(((DateTime)item.CommentCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Shared\Components\GetLastCommentsByWriter\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591