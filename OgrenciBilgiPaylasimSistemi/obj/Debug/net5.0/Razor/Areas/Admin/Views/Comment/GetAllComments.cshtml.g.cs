#pragma checksum "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28146214121d910be65c78077a0d48aec80fcebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_GetAllComments), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/GetAllComments.cshtml")]
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
#line 1 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28146214121d910be65c78077a0d48aec80fcebe", @"/Areas/Admin/Views/Comment/GetAllComments.cshtml")]
    public class Areas_Admin_Views_Comment_GetAllComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
  
    ViewData["Title"] = "GetAllComments";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28146214121d910be65c78077a0d48aec80fcebe3248", async() => {
                WriteLiteral("\r\n    <style>\r\n        a{\r\n            color:dimgray;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"




<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""ibox "">

            <div class=""ibox-content"">

                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">Yorumlar</th>
                            <th scope=""col"">Ba??l??k</th>
                            <th scope=""col"">Tarih</th>
                            <th scope=""col"">Blog</th>
                            <th scope=""col"">Yazar</th>
                            <th scope=""col"">Yorum</th>
                            <th scope=""col"">Sil</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 38 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th><a");
            BeginWriteAttribute("href", " href=\"", 1125, "\"", 1167, 2);
            WriteAttributeValue("", 1132, "/Blog/BlogDetails/", 1132, 18, true);
#nullable restore
#line 41 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
WriteAttributeValue("", 1150, item.Blog.BlogID, 1150, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Detay</a></th>\r\n                                <td ><a");
            BeginWriteAttribute("href", " href=\"", 1248, "\"", 1290, 2);
            WriteAttributeValue("", 1255, "/Blog/BlogDetails/", 1255, 18, true);
#nullable restore
#line 42 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
WriteAttributeValue("", 1273, item.Blog.BlogID, 1273, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
                                                                              Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1359, "\"", 1401, 2);
            WriteAttributeValue("", 1366, "/Blog/BlogDetails/", 1366, 18, true);
#nullable restore
#line 43 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
WriteAttributeValue("", 1384, item.Blog.BlogID, 1384, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
                                                                             Write(item.CommentCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1475, "\"", 1517, 2);
            WriteAttributeValue("", 1482, "/Blog/BlogDetails/", 1482, 18, true);
#nullable restore
#line 44 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
WriteAttributeValue("", 1500, item.Blog.BlogID, 1500, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
                                                                             Write(item.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>  </td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1590, "\"", 1633, 2);
            WriteAttributeValue("", 1597, "/Writer/WriterProfile/", 1597, 22, true);
#nullable restore
#line 45 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
WriteAttributeValue("", 1619, item.WriterID, 1619, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
                                                                              Write(item.Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1707, "\"", 1749, 2);
            WriteAttributeValue("", 1714, "/Blog/BlogDetails/", 1714, 18, true);
#nullable restore
#line 46 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
WriteAttributeValue("", 1732, item.Blog.BlogID, 1732, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
                                                                             Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1843, "\"", 1894, 2);
            WriteAttributeValue("", 1850, "/Admin/Comment/DeleteComment/", 1850, 29, true);
#nullable restore
#line 47 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"
WriteAttributeValue("", 1879, item.CommentID, 1879, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Areas\Admin\Views\Comment\GetAllComments.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
