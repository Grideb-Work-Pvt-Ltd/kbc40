#pragma checksum "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a22de948efa5efd2d92a9a57948bdb464c5c93b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Needanoffersummary), @"mvc.1.0.view", @"/Views/Admin/Needanoffersummary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a22de948efa5efd2d92a9a57948bdb464c5c93b", @"/Views/Admin/Needanoffersummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Needanoffersummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.kycmodellist>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delnoffer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
  
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    
    <section class=""content"">
        <input type=""text"" id=""myInput"" class=""mt-5"" onkeyup=""mysearch()"" placeholder=""Search for names.."">
        <table id=""tbl_exporttable_to_xls"" class=""table table-bordered"" style=""box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px; background-color:#6e75784a;"">
            <thead>
                <tr>
                    <th scope=""col"">S.No.</th>
                    <th scope=""col"">Start Date</th>
                    <th scope=""col"">End Date</th>

                    <th scope=""col"">Self Income </th>
                    <th scope=""col"">Start Rank</th>
                    <th scope=""col"">Achive Rank</th>
                    <th scope=""col"">Time</th>
                    <th scope=""col"">
                        Direct


                    </th>
                    <th scope=""col"">
                        Direct Income


                    </th>
                    <th scope=""col"">
 ");
            WriteLiteral(@"                       Start/Rank


                    </th>
                    <th scope=""col"">
                        Upgrade direct
                    </th>
                    <th scope=""col"">
                        Upgrade amount
                    </th>
                    <th scope=""col"">
                       Action
                    </th>




                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 52 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                 if (Model == null)
                {

                }
                else
                {
                    int i = 0;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                     foreach (var item in Model.kyclist)
                    {
                        i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">");
#nullable restore
#line 64 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 67 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.SelfIncome);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.RankF);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.RankU);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.Direct);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                   \r\n                    <td>\r\n                        ");
#nullable restore
#line 87 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.TTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 91 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.DirectIncome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 95 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.SType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 99 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.GDirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 103 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                   Write(item.GAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n\r\n                   \r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a22de948efa5efd2d92a9a57948bdb464c5c93b9751", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" name=\"userid\"");
                BeginWriteAttribute("value", " value=\"", 3061, "\"", 3082, 1);
#nullable restore
#line 111 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
WriteAttributeValue("", 3069, item.indexid, 3069, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                            <button class=\"btn btn-danger\" type=\"submit\">Delete</button>\r\n                        ");
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
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 117 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "D:\all project\kbc40\Views\Admin\Needanoffersummary.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.kycmodellist> Html { get; private set; }
    }
}
#pragma warning restore 1591
