#pragma checksum "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4a618ff800290cf62ac610a284b15c7f5129b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Annualsubscription), @"mvc.1.0.view", @"/Views/Admin/Annualsubscription.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4a618ff800290cf62ac610a284b15c7f5129b4", @"/Views/Admin/Annualsubscription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Annualsubscription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.income>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
  
    ViewData["Title"] = "Annual Subscription";
    Layout = "~/views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <section class=""content"">
        

        <section>
            <h1 class=""h1-12"">Annual Subscription</h1>
            <!--for demo wrap-->
            <div class=""tbl-header"">
                <button onclick=""ExportToExcel('xlsx')"" class=""btn btn-success text-white"" style=""margin-top:78px;background-color: #23085a!important;"">Export table to excel</button>
                <table id=""tbl_exporttable_to_xls"" class=""table"" cellpadding=""0"" cellspacing=""0"" border=""0"">
                    <thead style="" background-color: #000 !important; color:#fff;"">
                        <tr>
                            <th>Index</th>
                            <th>Userid</th>
                            <th>Name</th>
                            <th>Wallet</th>
                            <th>Amount</th>
                            <th>Details</th>
                            <th>Cr Dr</th>
                            <th>Date</th>
                        </tr>
      ");
            WriteLiteral("              </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 30 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                         foreach (var item in Model.incomelist)

                        {
                            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th class=\"row-incom\">");
#nullable restore
#line 38 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 39 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                               Write(item.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>Needan</td>\r\n                                <td>");
#nullable restore
#line 42 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                               Write(item.NetAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                               Write(item.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                               Write(item.InOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                               Write(item.tDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 48 "D:\all project\kbc40\Views\Admin\Annualsubscription.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </section>
    </section>
</div>

<script type=""text/javascript"" src=""https://unpkg.com/xlsx@0.15.1/dist/xlsx.full.min.js""></script>
<script>

        function ExportToExcel(type, fn, dl) {
            var elt = document.getElementById('tbl_exporttable_to_xls');
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
