#pragma checksum "D:\KBC40MVCCore\Views\User\charitywallet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f487bc0402d0fbd74e4973a0aad543d0f6352f6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_charitywallet), @"mvc.1.0.view", @"/Views/User/charitywallet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f487bc0402d0fbd74e4973a0aad543d0f6352f6f", @"/Views/User/charitywallet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_charitywallet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\User\charitywallet.cshtml"
  
    ViewData["Title"] = "AddFund";
    Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .slidecontainer {
        width: 100%;
    }

    .slider {
        -webkit-appearance: none;
        width: 100%;
        height: 25px;
        background: #d3d3d3;
        outline: none;
        opacity: 0.7;
        -webkit-transition: .2s;
        transition: opacity .2s;
    }

    /* Style the range input track */
    .custom-range::-webkit-slider-runnable-track {
        background-color: #28a745; /* Green color */
    }

    .custom-range::-moz-range-track {
        background-color: #28a745; /* Green color */
    }

    /* Style the range input thumb (slider handle) */
    .custom-range::-webkit-slider-thumb {
        background-color: #28a745; /* Green color */
    }

    .custom-range::-moz-range-thumb {
        background-color: #28a745; /* Green color */
    }


       

        .slider:hover {
            opacity: 1;
        }

        .slider:-webkit-slider-thumb {
            -webkit-appearance: none;
            appearance: none;
       ");
            WriteLiteral(@"     width: 25px;
            height: 25px;
            background: #04AA6D;
            cursor: pointer;
           
        }

        .slider:-moz-range-thumb {
            width: 25px;
            height: 25px;
            background: #04AA6D;
            cursor: pointer;
         
        }
    .range-container {
        position: relative;
        margin-top: 30px;

    }

    .label {
        position: absolute;
        top: -20px;
        left: 0;
        width: 100%;
        display: flex;
        justify-content: space-between;
    }
    #rangeInput {
        opacity: 0.5; /* Adjust the opacity to your preference */
      
        cursor: not-allowed; /* Change the cursor style to indicate it's not clickable */
    }
</style>


<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""co");
            WriteLiteral("l-sm-12\">\r\n                    <center> <h1");
            BeginWriteAttribute("class", " class=\"", 2187, "\"", 2195, 0);
            EndWriteAttribute();
            WriteLiteral(@">Volunteer Welfare Fund</h1></center>
                   
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        

                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>

    <!-- Main content -->
    <section class=""content"">

        <div");
            BeginWriteAttribute("class", " class=\"", 2649, "\"", 2657, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <center><h4>Add funds in your Charity wallet and get 2x Volunteer Welfare fund</h4></center>
            <div class=""container"">
                <div class=""col-sm-12"">
                    <div class=""slidecontainer"">
                        <div class=""mt-300"">


                            <div class=""col-md-6"">
                                <h3>Charity Wallet</h3>
                                <div class=""form-group"">

                                    <label hidden>Your Fund</label >
                                    <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3259, "\"", 3277, 1);
#nullable restore
#line 121 "D:\KBC40MVCCore\Views\User\charitywallet.cshtml"
WriteAttributeValue("", 3267, Model.vol, 3267, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly hidden/>\r\n\r\n");
            WriteLiteral(@"
                                    <div class=""range-container"">
                                        <div class=""label"">
                                            <span>0%</span>
                                            <span>100%</span>
                                        </div>
                                        <input type=""range"" class=""form-control btn btn-success"" min=""0"" max=""100""");
            BeginWriteAttribute("value", " value=\"", 3840, "\"", 3862, 1);
#nullable restore
#line 130 "D:\KBC40MVCCore\Views\User\charitywallet.cshtml"
WriteAttributeValue("", 3848, Model.persent, 3848, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"rangeInput\" disabled >\r\n                                        <div id=\"percentageDisplay\">");
#nullable restore
#line 131 "D:\KBC40MVCCore\Views\User\charitywallet.cshtml"
                                                               Write(Model.persent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</div>
                                    </div>
                                </div>
                            </div>
                            <div class=""text-right"">
                                <a href=""addfundpay"" class=""btn btn-primary "">Add Fund</a>
                            </div>
                            <div class=""col-md-6"">
                                <h3>Fund Summary </h3>
                                <div class=""form-group"" hidden>
                                    <label>Deposited Fund</label>
                                    <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4600, "\"", 4620, 1);
#nullable restore
#line 142 "D:\KBC40MVCCore\Views\User\charitywallet.cshtml"
WriteAttributeValue("", 4608, Model.locks, 4608, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                                    <label>Received Fund</label>\r\n                                    <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4776, "\"", 4798, 1);
#nullable restore
#line 144 "D:\KBC40MVCCore\Views\User\charitywallet.cshtml"
WriteAttributeValue("", 4784, Model.unlocks, 4784, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                                    <label>Balance Fund</label>\r\n                                    <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4953, "\"", 4984, 1);
#nullable restore
#line 146 "D:\KBC40MVCCore\Views\User\charitywallet.cshtml"
WriteAttributeValue("", 4961, Model.prelaunchcapping, 4961, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />



                                </div>

                            </div>
                        </div>

                        
                   </div>

              </div>

            </div>
        </div>
       

    </section>
</div>

");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
