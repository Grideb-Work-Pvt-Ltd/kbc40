#pragma checksum "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac199c9639f44ee9de87da9e7e6cc0cd34c6f1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PaymentSummery), @"mvc.1.0.view", @"/Views/Admin/PaymentSummery.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac199c9639f44ee9de87da9e7e6cc0cd34c6f1a", @"/Views/Admin/PaymentSummery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PaymentSummery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.income>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
  
    ViewData["Title"] = "withdrawalsummary";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    table.dataTable tbody tr {
        background-color: #272672;
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
                    <h1 class=""m-0"">Payment Summary</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Business Panel</a></li>

                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->");
            WriteLiteral(@"
        </div><!-- /.container-fluid -->
    </div>

    <!-- Main content -->
    <section class=""content"">

        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 mt-3"">
                    <button onclick=""ExportToExcel('xlsx')"" class=""btn btn-success text-white"" style=""margin-top:78px;background-color: #23085a!important;"">Export table to excel</button>
                    <div class=""table"">
                        <input id=""myInput"" type=""text"" placeholder=""Search.."" />
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"">S.No.</th>
                                    <th scope=""col"">User Id</th>
                                    <th scope=""col"">Name</th>
                              ");
            WriteLiteral(@"      <th scope=""col"">Detail</th>
                                    <th scope=""col"">Amount</th>
                                    <th scope=""col"">Account</th>
                                    <th scope=""col"">IFSC</th>
                                    <th scope=""col"">BANK</th>
                                    <th scope=""col"">Status</th>
                                    <th scope=""col"">Transaction Charge</th>
                                    <th scope=""col"">TDS</th>
                                    <th scope=""col"">Net Amount</th>
                                    <th scope=""col"">Date</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 80 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                 foreach (var item in Model.incomelist)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 87 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 88 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 89 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 90 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 91 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.amount1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 92 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.accountno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 93 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.ifsc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 93 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                               Write(item.branch);

#line default
#line hidden
#nullable disable
            WriteLiteral(") </td>\r\n                                    <td>");
#nullable restore
#line 94 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.bankname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 95 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                     if (@item.tstatus == "1")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Paid</td>\r\n");
#nullable restore
#line 98 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Reject</td>\r\n");
#nullable restore
#line 102 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 103 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.AdminCharge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 104 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.TDS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 105 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.NetAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 106 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
                                   Write(item.tDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 108 "D:\all project\kbc40\Views\Admin\PaymentSummery.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.income> Html { get; private set; }
    }
}
#pragma warning restore 1591