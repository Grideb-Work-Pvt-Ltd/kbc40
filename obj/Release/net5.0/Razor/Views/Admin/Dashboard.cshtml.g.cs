#pragma checksum "D:\all project\kbc40\Views\Admin\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3871431bddad4d296c2c1a6e1818decde0e018"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Dashboard), @"mvc.1.0.view", @"/Views/Admin/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3871431bddad4d296c2c1a6e1818decde0e018", @"/Views/Admin/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.dashboardmodel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
  
    ViewData["Title"] = "admin";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    *{
        color:white;
    }
</style>


<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Dashboard</h1>
                </div><!-- /.col -->

            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <!-- Small boxes (Stat box) -->
            <div class=""row"">
                <div class=""col-lg-4"">
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5> <i class=""nav-icon fas fa-chart-pie""></i> Total User</h5>
                    </div>
                    <div class=""sm");
            WriteLiteral("all-box\" style=\"background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);\">\r\n                        <div class=\"inner p-4\">\r\n                            <h2>");
#nullable restore
#line 38 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                           Write(Model.Totalcount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>
                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-4"">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5> <i class=""nav-icon fas fa-user""></i> Today User</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2>");
#nullable restore
#line 55 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                           Write(Model.todaycount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-4"">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-users""></i>Active User</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 74 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.ActiveStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>
                </div>

                <!-- ./col -->
            </div>
            <div class=""row"">
                <div class=""col-lg-4"">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5> <i class=""nav-icon fas fa-table""></i> Today Invest</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 96 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.todayinvest);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-4"">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-image""></i>Total Invest</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 115 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.Totalinvest);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>
                </div>
                <!-- ./col -->
                <div class=""col-lg-4 "">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-envelope""></i>Needan Wallet</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 134 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>
                </div>

                <!-- ./col -->
                <div class=""col-lg-4 "">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-envelope""></i>KBC Wallet</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 154 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.kbc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>

                </div>
                <div class=""col-lg-4 "">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-envelope""></i>House fund</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 173 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.house);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>

                </div>
                <div class=""col-lg-4 "">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-envelope""></i>Car fund</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 192 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.car);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>

                </div>
                <div class=""col-lg-4 "">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-envelope""></i> Travel</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 211 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.travral);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>

                </div>
                <div class=""col-lg-4 "">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-envelope""></i>Donation</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 230 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.donation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>

                </div>
                <div class=""col-lg-4 "">
                    <!-- small box -->
                    <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                        <h5><i class=""nav-icon fas fa-envelope""></i>Volunteer welfare</h5>

                    </div>
                    <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                        <div class=""inner p-4"">

                            <h2> ");
#nullable restore
#line 249 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                            Write(Model.velfund);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                        </div>
                        <div class=""icon"">
                            <i class=""ion ion-person-add""></i>
                        </div>

                    </div>

                </div>
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5> <i class=""nav-icon fas fa-table""></i> Direct Income</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 269 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.direct);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>
                    <!-- ./col -->
                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5><i class=""nav-icon fas fa-image""></i> Green Fund</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 288 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.GreenWallet);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>
                    <!-- ./col -->
                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5><i class=""nav-icon fas fa-image""></i>Associate</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 307 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.zero);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>

                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5><i class=""nav-icon fas fa-image""></i>Bronze</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 326 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.one);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5><i class=""nav-icon fas fa-image""></i>Silver</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 344 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.two);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5><i class=""nav-icon fas fa-image""></i>Gold</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 362 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.three);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5><i class=""nav-icon fas fa-image""></i>Pearl</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 380 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.four);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5><i class=""nav-icon fas fa-image""></i>Topaz</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 398 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.five);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <!-- small box -->
                        <div class=""card-header"" style=""line-height: 0.2; background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);"">
                            <h5><i class=""nav-icon fas fa-image""></i>Diamond</h5>

                        </div>
                        <div class=""small-box"" style=""background-image: linear-gradient(180deg, #3f3875, #343470, #433e63);"">
                            <div class=""inner p-4"">

                                <h2> ");
#nullable restore
#line 416 "D:\all project\kbc40\Views\Admin\Dashboard.cshtml"
                                Write(Model.six);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person-add""></i>
                            </div>

                        </div>
                    </div>
                    <!-- ./col -->
                </div>





                <!-- /.row (main row) -->
            </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.dashboardmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
