#pragma checksum "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78094977f0458a511feade4c69dea27946774bf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 1 "E:\c#web\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c#web\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78094977f0458a511feade4c69dea27946774bf9", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card bg-default shadow"">
            <div class=""card-header bg-transparent border-0"">
                <h3 class=""text-white mb-0"">Projelerim</h3>
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-dark table-flush"">
                    <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"" class=""sort"" data-sort=""name"">Proje</th>
                        <th scope=""col"" class=""sort"" data-sort=""budget"">??cret</th>
                        <th scope=""col"" class=""sort"" data-sort=""status"">Durum</th>
                      
                        <th scope=""col"" class=""sort"" data-sort=""completion"">Tamamlanma Oran??</th>
                        <th scope=""col"">Sil</th>
                        <th scope=""col"">D??zenle</th>
                    </tr>
                    </thead>
                    <tbody class=""list"">
");
#nullable restore
#line 29 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr>
                            <th scope=""row"">
                                <div class=""media align-items-center"">
                                    <a href=""#"" class=""avatar rounded-circle mr-3"">
                                        <img alt=""Image placeholder""");
            BeginWriteAttribute("src", " src=\"", 1534, "\"", 1554, 1);
#nullable restore
#line 35 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1540, item.Platform, 1540, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </a>\r\n                                    <div class=\"media-body\">\r\n                                        <span class=\"name mb-0 text-sm\">");
#nullable restore
#line 38 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </th>\r\n                            <td class=\"budget\">\r\n                                ");
#nullable restore
#line 43 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                            <td>
                                <span class=""badge badge-dot mr-4"">
                                    <i class=""bg-success""></i>
                                    <span class=""status"">Tamamland??</span>
                                </span>
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""completion mr-2"">");
#nullable restore
#line 53 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
                                                             Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                    <div>\r\n                                        <div class=\"progress\">\r\n                                            <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2720, "\"", 2747, 1);
#nullable restore
#line 56 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 2736, item.Value, 2736, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 2786, "\"", 2813, 3);
            WriteAttributeValue("", 2794, "width:", 2794, 6, true);
#nullable restore
#line 56 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue(" ", 2800, item.Value, 2801, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2812, ";", 2812, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3058, "\"", 3109, 2);
            WriteAttributeValue("", 3065, "/Portfolio/DeletePortfolio/", 3065, 27, true);
#nullable restore
#line 62 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 3092, item.PortfolioID, 3092, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3185, "\"", 3234, 2);
            WriteAttributeValue("", 3192, "/Portfolio/EditPortfolio/", 3192, 25, true);
#nullable restore
#line 63 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 3217, item.PortfolioID, 3217, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btn-outline-warning\">D??zenle</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 66 "E:\c#web\Core_Proje\Core_Proje\Views\Portfolio\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n               \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<a href=\"/Portfolio/AddPortfolio/\" class=\"btn btn-primary\">Yeni Proje EKLE</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
