#pragma checksum "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b96744fb494b17a90d5b463780bf865947fa43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vacancy_Details), @"mvc.1.0.view", @"/Views/Vacancy/Details.cshtml")]
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
#line 1 "D:\Programming\Project\eProject3_1\eProject3_1\Views\_ViewImports.cshtml"
using eProject3_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Project\eProject3_1\eProject3_1\Views\_ViewImports.cshtml"
using eProject3_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b96744fb494b17a90d5b463780bf865947fa43", @"/Views/Vacancy/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c0376d0f2a13f3bc0496319e08a829828958c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Vacancy_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eProject3_1.Models.Vacancy>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
  
    ViewData["Title"] = "Details";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Vacancy</h4>\r\n    <hr/>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Close));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.Close));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepartmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>

</div>
<div>
    <h3>List vacancy</h3>
    <table class=""table"">
        <tr>
            <th>
                <h4>Id</h4>
            </th>
            <th>
                <h4>Name</h4>
            </th>
            <th>
                <h4>Email</h4>
            </th>
            <th>
                <h4>Phone</h4>
            </th>
        </tr>
");
#nullable restore
#line 88 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
         foreach (Applicant app in (List<Applicant>) ViewBag.Apps)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 92 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
                   Write(app.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 95 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
                   Write(app.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 98 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
                   Write(app.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 101 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
                   Write(app.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 104 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 108 "D:\Programming\Project\eProject3_1\eProject3_1\Views\Vacancy\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {id = Model.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b96744fb494b17a90d5b463780bf865947fa4311844", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eProject3_1.Models.Vacancy> Html { get; private set; }
    }
}
#pragma warning restore 1591
