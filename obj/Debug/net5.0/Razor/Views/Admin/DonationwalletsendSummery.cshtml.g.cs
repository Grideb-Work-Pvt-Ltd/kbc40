#pragma checksum "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df898caf2afee56e01c4721709cdeaffeaa0d7da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DonationwalletsendSummery), @"mvc.1.0.view", @"/Views/Admin/DonationwalletsendSummery.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df898caf2afee56e01c4721709cdeaffeaa0d7da", @"/Views/Admin/DonationwalletsendSummery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DonationwalletsendSummery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.kycmodellist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
  
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <section class=""content"">

        <section>
            <h1 class=""h1-12"">Donation Request</h1>
            <!--for demo wrap-->
            <div class=""tbl-header"">
                <div id=""name"" style=""color:red;""></div>
                <table class=""table table-responsive-sm"" cellpadding=""0"" cellspacing=""0"" border=""0"">
                    <thead class=""bg-dark"" style="" color:#fff;"">
                        <tr>
                            <th>Index</th>
                            <th>Userid</th>
                            <th>Amount</th>
                            <th>Cr/Dr</th>
                            <th>Date</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 58 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
                         foreach (var item in Model.kyclist)
                        {
                            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th class=\"row-incom\">");
#nullable restore
#line 65 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td id=\"Userid\">");
#nullable restore
#line 66 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
                                           Write(item.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td id=\"amount\">");
#nullable restore
#line 67 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
                                           Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td id=\"transection\">");
#nullable restore
#line 68 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
                                                Write(item.transection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td id=\"transection\">");
#nullable restore
#line 69 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
                                                Write(item.tdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 73 "D:\KBC40MVCCore\Views\Admin\DonationwalletsendSummery.cshtml"
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


<script src=""https://code.jquery.com/jquery-3.3.1.min.js"" crossorigin=""anonymous""></script>
<script language=""javascript"" type=""text/javascript"">
    function myFunction() {
        let Userid = document.getElementById(""Userid"").value
        let amount = document.getElementById(""amount"").value

        $.ajax({
            url: '../Admin/greenwallet',
            data: { userid: Userid, amount: amount, transection: transection },
            type: ""POST"",
            success: function (data) {
                console.log(data);
                document.getElementById(""name"").innerHTML = data.name
            }
        });
    };
</script>");
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
