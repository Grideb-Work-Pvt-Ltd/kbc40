#pragma checksum "D:\all project\kbc40\Views\Admin\userlist2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70dcc0e71a8906529bed65591699936d65cf1481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_userlist2), @"mvc.1.0.view", @"/Views/Admin/userlist2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dcc0e71a8906529bed65591699936d65cf1481", @"/Views/Admin/userlist2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_userlist2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\all project\kbc40\Views\Admin\userlist2.cshtml"
  
    ViewData["Title"] = "userlist";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
.loader {
  border: 16px solid #f3f3f3;
  border-radius: 50%;
  border-top: 16px solid #3498db;
  width: 120px;
  height: 120px;
  -webkit-animation: spin 2s linear infinite; /* Safari */
  animation: spin 2s linear infinite;
}

/* Safari */
");
            WriteLiteral("@-webkit-keyframes spin {\r\n  0% { -webkit-transform: rotate(0deg); }\r\n  100% { -webkit-transform: rotate(360deg); }\r\n}\r\n\r\n");
            WriteLiteral(@"@keyframes spin {
  0% { transform: rotate(0deg); }
  100% { transform: rotate(360deg); }
}
</style>

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
            <center>
                <div id=""loader"" class=""loader""></di");
            WriteLiteral(@"v>
            </center>
            <div class=""row"">
                <div class=""col-lg-12 mt-3"">
                    <div class=""table"">

                        <table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"" style=""font-size:14px;"">
                            <thead class=""table-light-head"">
                                <tr class=""table-border"">
                                    <th scope=""col"" class=""table-border"">S.no</th>
                                    <th scope=""col"" class=""table-border"">Name</th>
                                    <th scope=""col"" class=""table-border"">User Id</th>
                                    <th scope=""col"" class=""table-border"">Sponsor Id</th>
                                    <th scope=""col"" class=""table-border"">Sponsor Name</th>
                                    <th scope=""col"" class=""table-border"">Parent Id</th>
                                    <th scope=""col"" class=""table-b");
            WriteLiteral(@"order"">Parent Name</th>
                                    <th scope=""col"" class=""table-border"">Password</th>
                                    <th scope=""col"" class=""table-border"">PAN CARD</th>
                                    <th scope=""col"" class=""table-border"">Donation</th>
                                    <th scope=""col"" class=""table-border"">Designation</th>
                                    <th scope=""col"" class=""table-border"">Direct</th>

                                    <th scope=""col"" class=""table-border"">Email</th>
                                    <th scope=""col"" class=""table-border"">Mobile</th>
                                    <th scope=""col"" class=""table-border"">Plan Name</th>
                                    <th scope=""col"" class=""table-border"">Country</th>
                                    <th scope=""col"" class=""table-border"">RegDate</th>
                                    <th scope=""col"" class=""table-border"">Active Date</th>
                               ");
            WriteLiteral(@"     <th scope=""col"" class=""table-border"">Status</th>
                                    <th scope=""col"" class=""table-border"">Charity Capping</th>
                                    <th scope=""col"" class=""table-border"">Prelaunch Capping</th>
                                </tr>
                            </thead>
                            <tbody class=""table-details"">
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.11.3/js/jquery.dataTables.js""></script>
<script>
   
</script>

<script type=""text/javascript"">

    $(document).ready(function () {
        hideTable();
        startLoader();
       
        $.ajax({
            type: ""GET"",
            url: ""../a");
            WriteLiteral(@"dmin/userlist3"",
            // dataType: ""json"", // Specify the expected data type
            success: function (response) {
                console.log(response)
                if (response && response.length > 0) {
                    // Clear any existing content in the table body
                    $('#mytable tbody').empty();

                    $.each(response, function (index, item) {
                        var row = ""<tr>""
                            + ""<td>"" + (index + 1) + ""</td>""
                            + ""<td>"" + item.name + ""</td>""
                            + ""<td><a href='profileupdate/?uid="" + item.userid + ""' style='color: #49bd82!important;'>"" + item.userid + ""</a></td>""
                            + ""<td>"" + item.sponsorid + ""</td>""
                            + ""<td>"" + item.sponsorname + ""</td>""
                            + ""<td>"" + item.parentid + ""</td>""
                            + ""<td>"" + item.parentname + ""</td>""
                            + ""<td>"" + i");
            WriteLiteral(@"tem.password + ""</td>""
                            + ""<td>"" + item.pancard + ""</td>""
                            + ""<td>"" + item.package + ""</td>""
                            + ""<td>"" + item.designation + ""</td>""
                            + ""<td>"" + item.direct + ""</td>""
                            + ""<td>"" + item.emailaddress + ""</td>""
                            + ""<td>"" + item.mobile + ""</td>""
                            + ""<td>"" + item.planename + ""</td>""
                            + ""<td>"" + item.city + ""</td>""
                            + ""<td>"" + item.regDate + ""</td>""
                            + ""<td>"" + item.activeDate + ""</td>""
                            + ""<td>"" + item.status + ""</td>""
                            + ""<td>"" + item.ccapping + ""</td>""
                            + ""<td>"" + item.pcapping + ""</td>""
                            + ""</tr>"";
                        $('#mytable tbody').append(row);
                    });
                    $(document).ready(function (");
            WriteLiteral(@") {
                        $('#mytable').DataTable();
                    });
                    hideLoader();
                    showTable();
                }
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });
</script>

<script>
    function startLoader() {
        document.getElementById(""loader"").style.display = ""block"";
    }

    // Function to hide the loader
    function hideLoader() {
        document.getElementById(""loader"").style.display = ""none"";
    }

    // Example usage:
    // Start the loader when an action begins
   

    // Hide the loader when the action completes
    // For example, after a delay of 3 seconds
    setTimeout(function () {
        hideLoader();
    }, 3000);
</script>
<script>
    function hideTable() {
        document.getElementById(""mytable"")");
            WriteLiteral(@".style.display = ""none"";
    }

    // Function to show the table
    function showTable() {
        document.getElementById(""mytable"").style.display = ""table""; // Set display property to ""table"" to show
    }

    // Example usage:
    // Hide the table initially
    

    // Show the table after a certain action, for example, after 3 seconds
    setTimeout(function () {
        showTable();
    }, 3000);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
