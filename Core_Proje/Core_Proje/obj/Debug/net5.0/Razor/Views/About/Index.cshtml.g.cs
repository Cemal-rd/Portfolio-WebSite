#pragma checksum "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2735cafdca4a649106f7e32f6fbbf99ba853ea05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2735cafdca4a649106f7e32f6fbbf99ba853ea05", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.About>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Hakkımda Kısmı Düzenleme Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 10 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
 using (Html.BeginForm("Index", "About", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.HiddenFor(x => x.AboutID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Başlık</label>\r\n");
#nullable restore
#line 15 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Açıklama</label>\r\n");
#nullable restore
#line 18 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Yaş</label>\r\n");
#nullable restore
#line 21 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x => x.Age, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Mail</label>\r\n");
#nullable restore
#line 24 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Resim</label>\r\n");
#nullable restore
#line 27 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 30 "E:\c#web\Core_Proje\Core_Proje\Views\About\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.About> Html { get; private set; }
    }
}
#pragma warning restore 1591
