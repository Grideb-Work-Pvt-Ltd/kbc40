#pragma checksum "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24595f810a5affda5e48bc9c84620e973f2c7c9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_bonanzaedit), @"mvc.1.0.view", @"/Views/Admin/bonanzaedit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24595f810a5affda5e48bc9c84620e973f2c7c9a", @"/Views/Admin/bonanzaedit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_bonanzaedit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.couponwallet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "updatbonanzaplan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Bonanza plane</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Direct Referral</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>

    <!-- Main content -->
    <section class=""content"">

        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">

                </div>
                <div class=""col-lg-6"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24595f810a5affda5e48bc9c84620e973f2c7c9a5381", async() => {
                WriteLiteral("\r\n                        <h4 style=\"color:red\">");
#nullable restore
#line 37 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
                                         Write(ViewBag.bag);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"formGroupExampleInput\">Start Date</label>\r\n                            <input type=\"datetime\" class=\"form-control\" name=\"startdate\"");
                BeginWriteAttribute("value", " value=\"", 1506, "\"", 1530, 1);
#nullable restore
#line 40 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
WriteAttributeValue("", 1514, Model.startdate, 1514, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group"">
                            <label for=""formGroupExampleInput2"">End Date</label>
                            <input type=""datetime"" class=""form-control"" id=""formGroupExampleInput2"" name=""enddate""");
                BeginWriteAttribute("value", " value=\"", 1812, "\"", 1834, 1);
#nullable restore
#line 44 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
WriteAttributeValue("", 1820, Model.enddate, 1820, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"formGroupExampleInput2\">Rank</label>\r\n                            <input type=\"number\" class=\"form-control\" name=\"rank\"");
                BeginWriteAttribute("value", " value=\"", 2079, "\"", 2098, 1);
#nullable restore
#line 48 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
WriteAttributeValue("", 2087, Model.rank, 2087, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"formGroupExampleInput2\">Direct</label>\r\n                            <input type=\"number\" class=\"form-control\" name=\"direct\"");
                BeginWriteAttribute("value", " value=\"", 2347, "\"", 2368, 1);
#nullable restore
#line 52 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
WriteAttributeValue("", 2355, Model.Direct, 2355, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"formGroupExampleInput2\">Hours</label>\r\n                            <input type=\"number\" class=\"form-control\" name=\"hours\"");
                BeginWriteAttribute("value", " value=\"", 2615, "\"", 2635, 1);
#nullable restore
#line 56 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
WriteAttributeValue("", 2623, Model.hours, 2623, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"formGroupExampleInput2\">Coupon</label>\r\n                            <input type=\"number\" class=\"form-control\" name=\"coupon\"");
                BeginWriteAttribute("value", " value=\"", 2884, "\"", 2905, 1);
#nullable restore
#line 60 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
WriteAttributeValue("", 2892, Model.coupon, 2892, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"formGroupExampleInput2\">Price</label>\r\n                            <input type=\"number\" class=\"form-control\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 3152, "\"", 3172, 1);
#nullable restore
#line 64 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
WriteAttributeValue("", 3160, Model.price, 3160, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"text\" class=\"form-control\" name=\"indexid\"");
                BeginWriteAttribute("value", " value=\"", 3258, "\"", 3280, 1);
#nullable restore
#line 65 "D:\KBC40MVCCore\Views\Admin\bonanzaedit.cshtml"
WriteAttributeValue("", 3266, Model.indexid, 3266, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden>
                        </div>

                        <div class=""form-group"">

                            <button type=""submit"" class=""btn btn"" id=""formGroupExampleInput2"" style=""background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);""><i class=""nav-icon fa fa-edit""></i>Update</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.couponwallet> Html { get; private set; }
    }
}
#pragma warning restore 1591