#pragma checksum "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "527103cf5dcb41dd8e4acd944cee597829c8b4c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DownlineTeam), @"mvc.1.0.view", @"/Views/Admin/DownlineTeam.cshtml")]
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
#line 1 "D:\all project\kbc40\Views\_ViewImports.cshtml"
using forex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\all project\kbc40\Views\_ViewImports.cshtml"
using forex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"527103cf5dcb41dd8e4acd944cee597829c8b4c8", @"/Views/Admin/DownlineTeam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DownlineTeam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.Downline>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownlineTeam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
  
    ViewData["Title"] = "TeamReferral";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /* table.dataTable tbody tr {
            background-color: #848821;
        }

        label {
            color: #fff;
        }
    */
    /*div#mytable_info {
            color: black;
        }

        a#mytable_previous {
            color: black !important;
        }

        a#mytable_next {
            color: black !important;
        }

        input[type=""search""] {
            color: black;
        }*/
</style>


<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Team Referral</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""../User/dashboard"">Dashboard</a></li>

       ");
            WriteLiteral("             </ol>\r\n                </div><!-- /.col -->\r\n            </div><!-- /.row -->\r\n        </div><!-- /.container-fluid -->\r\n    </div>\r\n\r\n    <!-- Main content -->\r\n    <section class=\"content\">\r\n        <div class=\"container\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "527103cf5dcb41dd8e4acd944cee597829c8b4c85385", async() => {
                WriteLiteral(@"
                <div class=""col-md-6"">
                    <div class=""form-group"">
                        <label>userid</label>
                        <input type=""text"" class=""form-control"" name=""uid"" />

                    </div>
                    <button type=""submit"" class=""btn btn-primary""> Downline</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </div>
        <div class=""container"">
            <div class=""row"">

                <div class=""col-lg-12 mt-3"">
                    <button onclick=""ExportToExcel('xlsx')"" class=""btn btn-success text-white"" style=""margin-top:78px;background-color: #23085a!important;"">Export table to excel</button>

                    <div class=""table-responsive table-rounds"">
                        <input id=""myInput"" type=""text"" placeholder=""Search.."" />
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"" class=""table-border"">S.no</th>
                                    <th scope=""col"" class=""table-border"">User id</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
");
            WriteLiteral(@"                                    <th scope=""col"" class=""table-border"">D.O.J</th>
                                    <th scope=""col"" class=""table-border"">Current Rank</th>
                                    <th scope=""col"" class=""table-border"">Plan</th>

                                </tr>
                            </thead>
                            <tbody class=""table-details"">
");
#nullable restore
#line 95 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                 if (Model.downlineparameters == null)
                                {
                                }
                                else
                                {

                                    int i = 0;

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                     foreach (var item in Model.downlineparameters)
                                    {
                                        i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">");
#nullable restore
#line 107 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <td>");
#nullable restore
#line 108 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                           Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 109 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                            <td>");
#nullable restore
#line 115 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                           Write(item.RegDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 116 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                           Write(item.designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 117 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                           Write(item.RankName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 119 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "D:\all project\kbc40\Views\Admin\DownlineTeam.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>
<script type=""text/javascript"" src=""https://unpkg.com/xlsx@0.15.1/dist/xlsx.full.min.js""></script>
<script>

    function ExportToExcel(type, fn, dl) {
        var elt = document.getElementById('mytable');
        var wb = XLSX.utils.table_to_book(elt, { sheet: ""sheet1"" });
        return dl ?
            XLSX.write(wb, { bookType: type, bookSST: true, type: 'base64' }) :
            XLSX.writeFile(wb, fn || ('MySheetName.' + (type || 'xlsx')));
    }

</script>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.Downline> Html { get; private set; }
    }
}
#pragma warning restore 1591
