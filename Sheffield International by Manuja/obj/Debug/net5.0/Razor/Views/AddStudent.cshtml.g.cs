#pragma checksum "C:\Users\Manuja\source\repos\Sheffield International by Manuja\Sheffield International by Manuja\Views\AddStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c75c4e198aa75038030cb3880fd68c925af9ded"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddStudent), @"mvc.1.0.view", @"/Views/AddStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c75c4e198aa75038030cb3880fd68c925af9ded", @"/Views/AddStudent.cshtml")]
    public class Views_AddStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sheffield_International_by_Manuja.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Manuja\source\repos\Sheffield International by Manuja\Sheffield International by Manuja\Views\AddStudent.cshtml"
  
    ViewData["Title"] = "AddStudent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>AddStudent</h1>

<h4>Student</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""AddStudent"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""id"" class=""control-label""></label>
                <input asp-for=""id"" class=""form-control"" />
                <span asp-validation-for=""id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""student_name"" class=""control-label""></label>
                <input asp-for=""student_name"" class=""form-control"" />
                <span asp-validation-for=""student_name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
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
#line 37 "C:\Users\Manuja\source\repos\Sheffield International by Manuja\Sheffield International by Manuja\Views\AddStudent.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sheffield_International_by_Manuja.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591