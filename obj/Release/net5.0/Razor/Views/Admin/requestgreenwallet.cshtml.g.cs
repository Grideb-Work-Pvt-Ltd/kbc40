#pragma checksum "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d7c10a68e6f22f2c8d196f6d081e878ef6ef3b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_requestgreenwallet), @"mvc.1.0.view", @"/Views/Admin/requestgreenwallet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7c10a68e6f22f2c8d196f6d081e878ef6ef3b8", @"/Views/Admin/requestgreenwallet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_requestgreenwallet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.kycmodellist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
  
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <section class=""content"">

        <section>
            <h1 class=""h1-12"">Green Request</h1>
            <!--for demo wrap-->
            <div class=""tbl-header"">
                <div id=""name"" style=""color:red;""></div>
                <table class=""table table-responsive-sm"" cellpadding=""0"" cellspacing=""0"" border=""0"">
                    <thead class=""bg-dark"" style="" color:#fff;"">
                        <tr>
                            <th>Index</th>
                            <th>Userid</th>
                            <th>Amount</th>
                            <th>Transaction Id</th>
                            <th>Image</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 58 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
                         foreach (var item in Model.kyclist)
                        {
                            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th class=\"row-incom\">");
#nullable restore
#line 65 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td id=\"Userid\">");
#nullable restore
#line 66 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
                                       Write(item.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td id=\"amount\">");
#nullable restore
#line 67 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
                                       Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td id=\"transection\">");
#nullable restore
#line 68 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
                                            Write(item.transection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3096, "\"", 3113, 1);
#nullable restore
#line 69 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
WriteAttributeValue("", 3103, item.bank, 3103, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3119, "\"", 3135, 1);
#nullable restore
#line 69 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
WriteAttributeValue("", 3125, item.bank, 3125, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:30px;\"></a></td>\r\n                           \r\n                        </tr>\r\n");
#nullable restore
#line 72 "D:\all project\kbc40\Views\Admin\requestgreenwallet.cshtml"
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
