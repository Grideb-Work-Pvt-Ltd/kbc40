#pragma checksum "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a220c6f15e2fbb37570ec6d73969b0a6cbac8d08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DirectReferral), @"mvc.1.0.view", @"/Views/User/DirectReferral.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a220c6f15e2fbb37570ec6d73969b0a6cbac8d08", @"/Views/User/DirectReferral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DirectReferral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.directlist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
  
    ViewData["Title"] = "DirectReferral";
    Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /*table.dataTable tbody tr {
        background-color: #834507;
    }

    label {
        color: #fff;
    }*/

    /*div#mytable_info {
        color: #000;
    }

    a#mytable_previous {
        color: #000 !important;
    }

    a#mytable_next {
        color: #000 !important;
    }

    input[type=""search""] {
        color: #000;
    }*/
</style>


<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Direct Referral</h1>
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
            <div class=""row"">

                <div class=""col-lg-12 mt-3"">
                    <div class=""table-responsive table-rounds"">
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"" class=""table-border"">S.no</th>
                                    <th scope=""col"" class=""table-border"">User id</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
                                    <th scope=""col"" class=""table-border"">Ranks</th>
                                    <th scope=""col"" class=""table-border"" hidden>Mobile</th>
");
            WriteLiteral("                                    <th scope=\"col\" class=\"table-border\">D.O.J</th>\r\n\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody class=\"table-details\">\r\n");
#nullable restore
#line 76 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                 foreach (var item in Model.directtotal)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 83 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 84 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                       Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 85 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td >");
#nullable restore
#line 86 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                        Write(item.ranks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td hidden>");
#nullable restore
#line 87 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                              Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                        <td>");
#nullable restore
#line 91 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                       Write(item.RegDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 93 "D:\KBC40MVCCore\Views\User\DirectReferral.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.directlist> Html { get; private set; }
    }
}
#pragma warning restore 1591