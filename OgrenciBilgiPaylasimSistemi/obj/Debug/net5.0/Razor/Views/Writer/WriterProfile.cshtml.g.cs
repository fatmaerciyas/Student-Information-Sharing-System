#pragma checksum "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Writer\WriterProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ab4a42b9522dccdcb106b94c622afe38ff1a869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterProfile), @"mvc.1.0.view", @"/Views/Writer/WriterProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ab4a42b9522dccdcb106b94c622afe38ff1a869", @"/Views/Writer/WriterProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e577ec8186a6180c55256e3394ed2437372d5f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Writer\WriterProfile.cshtml"
  
    ViewData["Title"] = "WriterProfile";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row animated fadeInRight"">
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Profil Detay??</h5>
                </div>
                <div>
                    <div class=""ibox-content no-padding border-left-right"">
                        <img alt=""image"" class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 557, "\"", 581, 1);
#nullable restore
#line 16 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Writer\WriterProfile.cshtml"
WriteAttributeValue("", 563, Model.WriterImage, 563, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"ibox-content profile-content\">\r\n                        <h4><strong>");
#nullable restore
#line 19 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Writer\WriterProfile.cshtml"
                               Write(Model.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\r\n                        <p><i class=\"fa fa-map-marker\"></i> ");
#nullable restore
#line 20 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Writer\WriterProfile.cshtml"
                                                       Write(Model.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <h5>\r\n                            Hakk??mda\r\n                        </h5>\r\n                        <p>\r\n                            ");
#nullable restore
#line 25 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Writer\WriterProfile.cshtml"
                       Write(Model.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-8\">\r\n\r\n            ");
#nullable restore
#line 35 "C:\Users\fatma\source\repos\OgrenciBilgiPaylasimSistemi\OgrenciBilgiPaylasimSistemi\Views\Writer\WriterProfile.cshtml"
       Write(await Component.InvokeAsync("BlogsByWriterProfile", new { id = ViewBag.writerID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
