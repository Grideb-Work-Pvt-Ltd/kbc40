#pragma checksum "D:\all project\kbc40\Views\Admin\couponwallet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7882e0857eea742781cf68d6eebbed0d0accbd6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_couponwallet), @"mvc.1.0.view", @"/Views/Admin/couponwallet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7882e0857eea742781cf68d6eebbed0d0accbd6e", @"/Views/Admin/couponwallet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_couponwallet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.couponlist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
  
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <section class=""content"">

        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 mt-3"">
                    <div class=""table-responsive table-rounds"">
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"" class=""table-border"">Index</th>
                                    <th scope=""col"" class=""table-border"">userid</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
                                    <th scope=""col"" class=""table-border"">Couponid</th>
                                    <th scope=""col"" class=""table-border"">Detail</th>
                                    <th scope=""col"" class=""table-border"">Amount</th>
");
            WriteLiteral(@"                                    <th scope=""col"" class=""table-border""> Date</th>
                                    <th scope=""col"" class=""table-border"">status</th>
                                    <th scope=""col"" class=""table-border"">Trasfer id</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
");
            WriteLiteral("                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 33 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                 foreach (var item in Model.couponslist)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 40 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td> ");
#nullable restore
#line 41 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                    Write(item.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td> ");
#nullable restore
#line 42 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                    Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 43 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                   Write(item.couponid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 44 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                   Write(item.createby);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 45 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                   Write(item.couponamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                    <td>");
#nullable restore
#line 47 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                   Write(item.cdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                   Write(item.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                   Write(item.transferto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                   Write(item.tname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 52 "D:\all project\kbc40\Views\Admin\couponwallet.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.couponlist> Html { get; private set; }
    }
}
#pragma warning restore 1591
