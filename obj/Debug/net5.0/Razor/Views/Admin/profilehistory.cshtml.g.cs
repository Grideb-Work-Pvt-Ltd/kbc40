#pragma checksum "D:\all project\kbc40\Views\Admin\profilehistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5137fc88240b191d2a8a182d97cf50373925f439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_profilehistory), @"mvc.1.0.view", @"/Views/Admin/profilehistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5137fc88240b191d2a8a182d97cf50373925f439", @"/Views/Admin/profilehistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_profilehistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.user>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
  
    ViewData["Title"] = "userlist";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
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
             <div class=""row"">
                <div class=""col-lg-12 mt-3"">
                    <div class=""table"">
                        <input id=""myInput"" type=""tex");
            WriteLiteral(@"t"" placeholder=""Search.."" />
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"" style=""font-size:14px;"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"" class=""table-border"">S.no</th>
                                    <th scope=""col"" class=""table-border"">User Id</th>
                                    <th scope=""col"" class=""table-border"">old Name</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
                                    <th scope=""col"" class=""table-border"">old Password</th>
                                    <th scope=""col"" class=""table-border"">Password</th>
                                    <th scope=""col"" class=""table-border"">old Email</th>
                                    <th scope=""col"" class=""table-border"">Email</th>
            ");
            WriteLiteral(@"                        <th scope=""col"" class=""table-border"">old Mobile</th>
                                    <th scope=""col"" class=""table-border"">Mobile</th>
                                    <th scope=""col"" class=""table-border"">old Plan Name</th>
                                    <th scope=""col"" class=""table-border"">Plan Name</th>
                                </tr>
                            </thead>
                            <tbody class=""table-details"">
");
#nullable restore
#line 55 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                 foreach (var item in Model.reglist)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td scope=\"row\">");
#nullable restore
#line 62 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>");
#nullable restore
#line 64 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 65 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.names);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 67 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.passwords);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 68 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    \r\n                                    <td>");
#nullable restore
#line 70 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.emailaddresss);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 71 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.emailaddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 72 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.Mobiles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 73 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>");
#nullable restore
#line 75 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.planenames);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 76 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
                                   Write(item.planename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                   \r\n                                </tr>\r\n");
#nullable restore
#line 79 "D:\all project\kbc40\Views\Admin\profilehistory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.user> Html { get; private set; }
    }
}
#pragma warning restore 1591