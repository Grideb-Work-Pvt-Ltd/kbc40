#pragma checksum "D:\KBC40MVCCore\Views\Admin\fund.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6160c6160dc1b1b2b408c35c5dfaf9c42188526e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_fund), @"mvc.1.0.view", @"/Views/Admin/fund.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6160c6160dc1b1b2b408c35c5dfaf9c42188526e", @"/Views/Admin/fund.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_fund : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.income>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
  
    ViewData["Title"] = "ProfitSharing";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

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
                    <h1 class=""m-0"">");
#nullable restore
#line 40 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                               Write(ViewBag.page);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">

                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>

    <!-- Main content -->
    <section class=""content"">

        <div class=""container"">
            <div class=""text-right mb-3"">
                <button class=""btn btn-primary"" onclick=""ExportToExcel('xlsx')""><i class=""fa fa-print"" style=""font-size: 13px; }""></i>Excell Download</button>

            </div>
            <div class=""row"">
                <div class=""col-lg-12 mt-3"">
                    <div class=""table-responsive table-rounds"">
                        <input id=""myInput"" type=""text"" placeholder=""Search.."" />
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
     ");
            WriteLiteral(@"                               <th scope=""col"" class=""table-border"">S. No</th>
                                    <th scope=""col"" class=""table-border"">Userid</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
                                    <th scope=""col"" class=""table-border"">Fund</th>
                                    <th scope=""col"" class=""table-border"">Cr/Dr</th>
                                    <th scope=""col"" class=""table-border"">Date</th>


                                </tr>
                            </thead>
                            <tbody class=""table-details"">
");
#nullable restore
#line 75 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                 foreach (var item in Model.incomelist)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td scope=\"row\">");
#nullable restore
#line 82 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 83 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                        Write(item.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 84 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 85 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                        Write(item.NetAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 86 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                       Write(item.InOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 87 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                        Write(item.tDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 89 "D:\KBC40MVCCore\Views\Admin\fund.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
