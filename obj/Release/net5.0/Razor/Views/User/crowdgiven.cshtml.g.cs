#pragma checksum "D:\all project\kbc40\Views\User\crowdgiven.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c28a790130697e90818a383f1eee07e4a80e65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_crowdgiven), @"mvc.1.0.view", @"/Views/User/crowdgiven.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c28a790130697e90818a383f1eee07e4a80e65", @"/Views/User/crowdgiven.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_crowdgiven : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.IncomeWallet>
    {
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
#line 2 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
  
    ViewData["Title"] = "TopupWallet";
    Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
   /* table.dataTable tbody tr {
        background-color: #3a5205ad;
    }

    label {
        color: #fff;
    }*/

    /*div#mytable_info {
        color: #fff;
    }

    a#mytable_previous {
        color: #fff !important;
    }

    a#mytable_next {
        color: #fff !important;
    }

    input[type=""search""] {
        color: #fff;
    }*/
</style>


<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Top up Wallet</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""../User/dashboard"">Dashboard</a></li>

                    </ol>
                </div><!-- /.col -->
            <");
            WriteLiteral(@"/div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>

    <!-- Main content -->
    <section class=""content"">

        <div class=""container"">
            <div class=""container"" hidden>
                <div class=""row"">
                    <div class=""col-sm-12"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70c28a790130697e90818a383f1eee07e4a80e654775", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label for=""formGroupExampleInput"">Total Top up Wallet</label>
                                <input type=""text"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""$"" readonly name=""amount""");
                BeginWriteAttribute("value", " value=\"", 1770, "\"", 1792, 1);
#nullable restore
#line 62 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
WriteAttributeValue("", 1778, Model.tamount, 1778, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 40vh;\">\r\n                            </div>\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-lg-12 mt-3"">
                    <div class=""table-responsive table-rounds"">
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"" class=""table-border"">Index</th>
                                    <th scope=""col"" class=""table-border"">User Name</th>
                                    <th scope=""col"" class=""table-border"">User Code</th>
                                    <th scope=""col"" class=""table-border"">Details</th>
                                    <th scope=""col"" class=""table-border"">Main</th>
                                    <th scope=""col"" class=""table-border"">Date</th>
                           ");
            WriteLiteral("     </tr>\r\n                            </thead>\r\n                            <tbody class=\"table-details\">\r\n");
#nullable restore
#line 85 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                 foreach (var item in Model.Incomewall)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th class=\"row-incom\">");
#nullable restore
#line 92 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 93 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                       Write(item.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 94 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                       Write(item.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 95 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                       Write(item.details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 96 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                       Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("                                        <td>");
#nullable restore
#line 99 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 101 "D:\all project\kbc40\Views\User\crowdgiven.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.IncomeWallet> Html { get; private set; }
    }
}
#pragma warning restore 1591
