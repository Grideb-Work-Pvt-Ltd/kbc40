#pragma checksum "D:\KBC40MVCCore\Views\User\community.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db1acc7f36c034cebe68e871bf2302cfcde7ef7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_community), @"mvc.1.0.view", @"/Views/User/community.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1acc7f36c034cebe68e871bf2302cfcde7ef7f", @"/Views/User/community.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_community : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.income>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\User\community.cshtml"
  
    ViewData["Title"] = "community";
    Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    table.dataTable tbody tr {
        background-color: #217788;
    }

    label {
        color: #fff;
    }

    div#mytable_info {
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
    }
</style>


<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Community Income</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""../User/dashboard"">Business Panel</a></li>

                    </ol>
                </div><!-- /.col -->
            </d");
            WriteLiteral(@"iv><!-- /.row -->
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
                                    <th scope=""col"" class=""table-border"">Index</th>
                                    <th scope=""col"" class=""table-border"">Fund</th>
                                    <th scope=""col"" class=""table-border"">Details</th>
                                    <th scope=""col"" class=""table-border"">Cr/Dr</th>
                                    <th scope=""col"" class=""table-border"">Date</th>


                        ");
            WriteLiteral("        </tr>\r\n                            </thead>\r\n                            <tbody class=\"table-details\">\r\n");
#nullable restore
#line 72 "D:\KBC40MVCCore\Views\User\community.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\KBC40MVCCore\Views\User\community.cshtml"
                                 foreach (var item in Model.incomelist)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 79 "D:\KBC40MVCCore\Views\User\community.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 80 "D:\KBC40MVCCore\Views\User\community.cshtml"
                                       Write(item.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 81 "D:\KBC40MVCCore\Views\User\community.cshtml"
                                        Write(item.NetAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 82 "D:\KBC40MVCCore\Views\User\community.cshtml"
                                       Write(item.InOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 83 "D:\KBC40MVCCore\Views\User\community.cshtml"
                                       Write(item.tDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 85 "D:\KBC40MVCCore\Views\User\community.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr>

                                
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>





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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.income> Html { get; private set; }
    }
}
#pragma warning restore 1591
