#pragma checksum "D:\all project\kbc40\Views\Admin\userlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39afc324592aab362e863a50686e35ea3ebb8e2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_userlist), @"mvc.1.0.view", @"/Views/Admin/userlist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39afc324592aab362e863a50686e35ea3ebb8e2d", @"/Views/Admin/userlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_userlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.user>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "block", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
  
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
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39afc324592aab362e863a50686e35ea3ebb8e2d6187", async() => {
                WriteLiteral(@"
                <div class=""form-group col-md-4 mx-auto"">
                    <label for=""formGroupExampleInput"">User ID</label>
                    <input type=""text"" class=""form-control"" name=""userid"">
                </div>
                <div class=""text-center"">
                    <button type=""submit"" class=""btn btn-primary pl-5 pr-5"">Submit</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button onclick=""ExportToExcel('xlsx')"" class=""btn btn-success text-white"" style=""margin-top:78px;background-color: #23085a!important;"">Export table to excel</button>
            <div class=""row"">
                <div class=""col-lg-12 mt-3"">
                    <div class=""table"">
                        <input id=""myInput"" type=""text"" placeholder=""Search.."" />
                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"" style=""font-size:14px;"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"" class=""table-border"">S.no</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
                                    <th scope=""col"" class=""table-border"">User Id</th>
                                    <th scope=""col"" class=""table-border"">Sponsor Id</th>
           ");
            WriteLiteral(@"                         <th scope=""col"" class=""table-border"">Sponsor Name</th>
                                    <th scope=""col"" class=""table-border"">Parent Id</th>
                                    <th scope=""col"" class=""table-border"">Parent Name</th>
                                    <th scope=""col"" class=""table-border"">Password</th>
                                    <th scope=""col"" class=""table-border"">PAN CARD</th>
                                    <th scope=""col"" class=""table-border"">Donation</th>
                                    <th scope=""col"" class=""table-border"">Designation</th>
                                    <th scope=""col"" class=""table-border"">Direct</th>
");
            WriteLiteral(@"                                    <th scope=""col"" class=""table-border"">Email</th>
                                    <th scope=""col"" class=""table-border"">Mobile</th>
                                    <th scope=""col"" class=""table-border"">Father</th>
                                    <th scope=""col"" class=""table-border"">pincode</th>
                                    <th scope=""col"" class=""table-border"">Dob</th>
                                    <th scope=""col"" class=""table-border"">Address</th>
                                    <th scope=""col"" class=""table-border"">Gender</th>
                                    <th scope=""col"" class=""table-border"">Plan Name</th>
                                    <th scope=""col"" class=""table-border"">Country</th>
                                    <th scope=""col"" class=""table-border"">RegDate</th>
                                    <th scope=""col"" class=""table-border"">Active Date</th>
                                    <th scope=""col"" class=""table-borde");
            WriteLiteral(@"r"">Main wallet</th>
                                    <th scope=""col"" class=""table-border"">Crowed wallet</th>
                                    <th scope=""col"" class=""table-border"">Status</th>
                                    <th scope=""col"" class=""table-border"">Charity Capping</th>
                                    <th scope=""col"" class=""table-border"">Prelaunch Capping</th>
                                    <th scope=""col"" class=""table-border"">Block/Unblock</th>
                                </tr>
                            </thead>
                            <tbody class=""table-details"">
");
#nullable restore
#line 119 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                  
                                    int i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                 foreach (var item in Model.reglist)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td scope=\"row\">");
#nullable restore
#line 126 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 127 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 6109, "\"", 6147, 2);
            WriteAttributeValue("", 6116, "profileupdate/?uid=", 6116, 19, true);
#nullable restore
#line 128 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
WriteAttributeValue("", 6135, item.userid, 6135, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: #49bd82!important;\">");
#nullable restore
#line 128 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                                                                                                   Write(item.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                        <td>");
#nullable restore
#line 129 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.Sponsorid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 130 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.Sponsorname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 131 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.parentid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 132 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.parentname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>");
#nullable restore
#line 134 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 135 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.pancard);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 136 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.package);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 137 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 138 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.direct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                        <td>");
#nullable restore
#line 140 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.emailaddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 141 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        \r\n                                        <td>");
#nullable restore
#line 143 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.father);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 144 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.pincode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 145 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.dob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 146 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 147 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                       \r\n                                        <td>");
#nullable restore
#line 149 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.planename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 150 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 151 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.RegDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 152 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.ActiveDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td");
            BeginWriteAttribute("id", " id=\"", 7702, "\"", 7724, 2);
            WriteAttributeValue("", 7707, "main_", 7707, 5, true);
#nullable restore
#line 153 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
WriteAttributeValue("", 7712, item.userid, 7712, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                                        <td");
            BeginWriteAttribute("id", " id=\"", 7776, "\"", 7799, 2);
            WriteAttributeValue("", 7781, "crowd_", 7781, 6, true);
#nullable restore
#line 154 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
WriteAttributeValue("", 7787, item.userid, 7787, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                                        <td>");
#nullable restore
#line 155 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>");
#nullable restore
#line 157 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.ccapping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 158 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
                                       Write(item.pcapping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39afc324592aab362e863a50686e35ea3ebb8e2d21308", async() => {
                WriteLiteral("\r\n                                                <select type=\"text\" name=\"block\">\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39afc324592aab362e863a50686e35ea3ebb8e2d21708", async() => {
                    WriteLiteral("Select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39afc324592aab362e863a50686e35ea3ebb8e2d22984", async() => {
                    WriteLiteral("BlockID");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39afc324592aab362e863a50686e35ea3ebb8e2d24261", async() => {
                    WriteLiteral("UnblockID");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                </select>\r\n                                                <input name=\"userid\"");
                BeginWriteAttribute("value", " value=\"", 8617, "\"", 8637, 1);
#nullable restore
#line 166 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
WriteAttributeValue("", 8625, item.userid, 8625, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                                                <button class=\"btn btn-box\" type=\"submit\">Submit</button>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 171 "D:\all project\kbc40\Views\Admin\userlist.cshtml"
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


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    // Function to generate QR code for each userid
    function myFunction(userid) {
        $.ajax({
            url: '../Home/MyActions',
            data: { id: userid },
            type: ""POST"",
            success: function (data) {
        ");
            WriteLiteral(@"        console.log(data.main);
                document.getElementById(""main_"" + userid).innerText = data.main;
                document.getElementById(""crowd_"" + userid).innerText = data.crowd;
            }
        });
    }

    $(document).ready(function () {
        // Iterate over each row in the table
        $('#mytable tbody tr').each(function () {
            // Find the userid value in the row
            var userid = $(this).find('td:eq(3)').text(); // Adjust the index based on the position of userid in your table
            // Call myFunction to generate QR code for the userid
             myFunction(userid);
            
        });
    });

    // Function to export table to Excel

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
