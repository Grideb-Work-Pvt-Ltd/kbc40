#pragma checksum "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1773a368fbbf2c9bf564461f1d69887b1abc6dd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_auserlist), @"mvc.1.0.view", @"/Views/Admin/auserlist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1773a368fbbf2c9bf564461f1d69887b1abc6dd1", @"/Views/Admin/auserlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_auserlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.user>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
  
    ViewData["Title"] = "userlist";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"

<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">User List</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">User List</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>

    <!-- Main content -->
    <section class=""content"">

        <div class=""container"">
           
            <button onclick=""ExportToExcel('xlsx')"" class=""btn btn-success text-white"" style=""margin-top:78px;background-color: #23085a!important;"">Export table to e");
            WriteLiteral(@"xcel</button>
            <div class=""row"">
                <div class=""col-lg-12 mt-3"">
                    <div class=""table-responsive table-rounds"">
                        <input id=""myInput"" type=""text"" placeholder=""Search.."" />
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"" style=""font-size:14px;"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"" class=""table-border"">S.no</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
                                    <th scope=""col"" class=""table-border"">User Id</th>
                                    <th scope=""col"" class=""table-border"">Email</th>
                                    <th scope=""col"" class=""table-border"">Mobile</th>
                                    <th scope=""col"" class=""table-border"">");
            WriteLiteral("Address</th>\r\n                                    <th scope=\"col\" class=\"table-border\">Image</th>\r\n\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody class=\"table-details\">\r\n");
#nullable restore
#line 89 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
                                 foreach (var item in Model.reglist)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td scope=\"row\">");
#nullable restore
#line 96 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 97 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
                                       Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 3604, "\"", 3642, 2);
            WriteAttributeValue("", 3611, "profileupdate/?uid=", 3611, 19, true);
#nullable restore
#line 98 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
WriteAttributeValue("", 3630, item.userid, 3630, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: #49bd82!important;\">");
#nullable restore
#line 98 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
                                                                                                                   Write(item.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                        <td>");
#nullable restore
#line 99 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
                                       Write(item.emailaddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 100 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
                                       Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 101 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
                                       Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 3943, "\"", 3961, 1);
#nullable restore
#line 102 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
WriteAttributeValue("", 3950, item.image, 3950, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ><img");
            BeginWriteAttribute("src", " src=\"", 3968, "\"", 3985, 1);
#nullable restore
#line 102 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
WriteAttributeValue("", 3974, item.image, 3974, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px;\"/></a></td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 105 "D:\KBC40MVCCore\Views\Admin\auserlist.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.user> Html { get; private set; }
    }
}
#pragma warning restore 1591