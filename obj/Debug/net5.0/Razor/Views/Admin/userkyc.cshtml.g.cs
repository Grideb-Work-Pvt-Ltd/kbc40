#pragma checksum "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd45515d8e19040df398c8f783f24a885d54a366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_userkyc), @"mvc.1.0.view", @"/Views/Admin/userkyc.cshtml")]
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
#line 1 "D:\KBC40MVCCore\Views\_ViewImports.cshtml"
using forex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\_ViewImports.cshtml"
using forex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd45515d8e19040df398c8f783f24a885d54a366", @"/Views/Admin/userkyc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_userkyc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.kycmodellist>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "userkyc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "updatekyc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "rejectkyc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
  
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd45515d8e19040df398c8f783f24a885d54a3665064", async() => {
                WriteLiteral(@"
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label>userid</label>
                <input type=""text"" class=""form-control"" name=""id"" />

            </div>
            <button class=""btn btn-primary""type=""submit"">submit</button>

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
    <section class=""content"">
        <input type=""text"" id=""myInput"" class=""mt-5"" onkeyup=""mysearch()"" placeholder=""Search for names.."">
        <table id=""tbl_exporttable_to_xls"" class=""table table-bordered"" style=""box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px; background-color:#6e75784a;"">
           <thead>
            <tr>
                <th scope=""col"">S.No.</th>
                <th scope=""col"">User ID</th>
                <th scope=""col"">Name</th>

                <th scope=""col"">Bank </th>
                <th scope=""col"">Pancard </th>
                <th scope=""col"">Adhaar</th>
                <th scope=""col""></th>
                <th scope=""col"">
                    Kyc


                </th>
                <th scope=""col"">
                    Action


                </th>
                <th scope=""col"">
                    Action


                </th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 49 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
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
#line 57 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                 foreach (var item in Model.kyclist)
                {
                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\">");
#nullable restore
#line 61 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 62 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                       Write(item.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>");
#nullable restore
#line 64 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                       Write(item.AccountHolderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            Account NO : ");
#nullable restore
#line 67 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                                    Write(item.accountno);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            IFSC : ");
#nullable restore
#line 68 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                              Write(item.ifsc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                            BANK NAME : ");
#nullable restore
#line 69 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                                   Write(item.branch);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2171, "\"", 2187, 1);
#nullable restore
#line 70 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
WriteAttributeValue("", 2177, item.bank, 2177, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" />\r\n\r\n                        </td>\r\n                        <td>\r\n                            PanNO : ");
#nullable restore
#line 74 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                               Write(item.pannumbr);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2360, "\"", 2379, 1);
#nullable restore
#line 75 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
WriteAttributeValue("", 2366, item.pancard, 2366, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" />\r\n                        </td>\r\n                        <td>\r\n                            Adhaar No : ");
#nullable restore
#line 78 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                                   Write(item.adharnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2557, "\"", 2579, 1);
#nullable restore
#line 79 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
WriteAttributeValue("", 2563, item.adharfront, 2563, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" />\r\n                        </td>\r\n                        <td>\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2694, "\"", 2715, 1);
#nullable restore
#line 83 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
WriteAttributeValue("", 2700, item.adharback, 2700, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" />\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd45515d8e19040df398c8f783f24a885d54a36612523", async() => {
                WriteLiteral("\r\n                                <input type=\"text\" name=\"userid\"");
                BeginWriteAttribute("value", " value=\"", 2944, "\"", 2964, 1);
#nullable restore
#line 88 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
WriteAttributeValue("", 2952, item.Userid, 2952, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                                <button class=\"btn btn-danger\" type=\"submit\">Active</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd45515d8e19040df398c8f783f24a885d54a36614806", async() => {
                WriteLiteral("\r\n                                <input type=\"text\" name=\"userid\"");
                BeginWriteAttribute("value", " value=\"", 3317, "\"", 3337, 1);
#nullable restore
#line 95 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
WriteAttributeValue("", 3325, item.Userid, 3325, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                                <button class=\"btn btn-danger\" type=\"submit\">Reject</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd45515d8e19040df398c8f783f24a885d54a36617085", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3579, "~/admin/bank?userid=", 3579, 20, true);
#nullable restore
#line 100 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
AddHtmlAttributeValue("", 3599, item.Userid, 3599, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 104 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\KBC40MVCCore\Views\Admin\userkyc.cshtml"
                 
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
