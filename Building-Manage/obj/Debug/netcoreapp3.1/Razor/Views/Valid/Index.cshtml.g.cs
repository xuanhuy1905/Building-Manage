#pragma checksum "D:\Web-Company DIP VN\Building-Manage\Building-Manage\Views\Valid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d94decf3e8f9801dd0b860ce38605eee2a945c96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Valid_Index), @"mvc.1.0.view", @"/Views/Valid/Index.cshtml")]
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
#line 1 "D:\Web-Company DIP VN\Building-Manage\Building-Manage\Views\_ViewImports.cshtml"
using Building_Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web-Company DIP VN\Building-Manage\Building-Manage\Views\_ViewImports.cshtml"
using Building_Manage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94decf3e8f9801dd0b860ce38605eee2a945c96", @"/Views/Valid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59fb1275898b0a6b50463fa582267af3850c0411", @"/Views/_ViewImports.cshtml")]
    public class Views_Valid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Web-Company DIP VN\Building-Manage\Building-Manage\Views\Valid\Index.cshtml"
  
    Layout = "_LoginLayout";
    ViewData["Title"] = "Xác Thực";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class="" my-5 wrap-input"">
    <label for=""PhoneNumber""></label>
    <input type=""text"" class=""input"" name=""PhoneNumber"" placeholder=""Nhập mã xác thực..."">
</div>
<div class="" d-flex justify-content-center my-5"">
    <button class=""btn btn-input btn-block btn-primary"">Xác nhận</button>
</div>
<div class=""mt-4"">
    <span>Gửi lại mã xác nhận!</span>
</div>");
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
