#pragma checksum "C:\Users\Manuja\source\repos\Sheffield International by Manuja\Sheffield International by Manuja\Views\UpdateGrade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "404975eb244f4fd1d55af2c6481e8c409c12f7fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UpdateGrade), @"mvc.1.0.view", @"/Views/UpdateGrade.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404975eb244f4fd1d55af2c6481e8c409c12f7fa", @"/Views/UpdateGrade.cshtml")]
    public class Views_UpdateGrade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sheffield_International_by_Manuja.Models.Grade>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Manuja\source\repos\Sheffield International by Manuja\Sheffield International by Manuja\Views\UpdateGrade.cshtml"
  
    ViewData["Title"] = "UpdateGrade";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>UpdateGrade</h1>

<h4>Grade</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""UpdateGrade"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""StudentId"" class=""control-label""></label>
                <input asp-for=""StudentId"" class=""form-control"" />
                <span asp-validation-for=""StudentId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SubjectId"" class=""control-label""></label>
                <input asp-for=""SubjectId"" class=""form-control"" />
                <span asp-validation-for=""SubjectId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""marks"" class=""control-label""></label>
                <input asp-for=""marks"" class=""form-control"" />
                <span asp-validation-for=""marks"" class=""text-danger");
            WriteLiteral(@"""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Grad"" class=""control-label""></label>
                <input asp-for=""Grad"" class=""form-control"" />
                <span asp-validation-for=""Grad"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Manuja\source\repos\Sheffield International by Manuja\Sheffield International by Manuja\Views\UpdateGrade.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sheffield_International_by_Manuja.Models.Grade> Html { get; private set; }
    }
}
#pragma warning restore 1591