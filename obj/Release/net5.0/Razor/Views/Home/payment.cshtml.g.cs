#pragma checksum "D:\KBC40MVCCore\Views\Home\payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f14018427fd6053cad380ef85db6a45efcb8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_payment), @"mvc.1.0.view", @"/Views/Home/payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9f14018427fd6053cad380ef85db6a45efcb8e6", @"/Views/Home/payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/Registers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/video/6617-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\KBC40MVCCore\Views\Home\payment.cshtml"
  
    ViewData["Title"] = "payment";
    Layout = "~/views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"" style=""margin-top:95px;"">
    <div class=""row"">

        <div class=""col-md-6 card p-4"" style=""border:dashed 1px solid green;"">
            <center>
                <div>
                    <script src=""https://cdn.lordicon.com/fudrjiwc.js""></script>
                    <lord-icon src=""https://cdn.lordicon.com/vlupvdhl.json""
                               trigger=""hover""
                               colors=""primary:#7166ee,secondary:#a866ee""
                               style=""width:250px;height:250px"">
                    </lord-icon>
                </div>
                <br />
                <div>
");
            WriteLiteral(@"
                    <button class=""btn btn-primary"" id=""btnPayment"" style=""display: inline-block;"">
                        Pay with PhonePay
                        <span class=""spinner"" style=""display: none""><i class=""fas fa-spinner fa-spin""></i></span>
                    </button>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9f14018427fd6053cad380ef85db6a45efcb8e64976", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </center>\r\n\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <center>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9f14018427fd6053cad380ef85db6a45efcb8e66210", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </center>
        </div>

    </div>
</div>
<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"">

<script>
    $(document).ready(function () {
       /* $(""#btnPayment"").click(function () {*/
            var intervalId; // Declare the intervalId variable to control the intervals
            var intervalCount = 0;
            $('#btnPayment').text('Processing Payment...');

            $.ajax({
                url: ""/Home/GeneratePaymentLink"", // Replace with your controller and action names
                type: ""POST"", // Change to POST to send data in the request body
                dataType: ""json"",

                contentType: ""application/json"", // Set the content type
                success: function (data) {
                   
                    let phonepeResponse = JSON.parse(data.phonepeResponse);
                    
          ");
            WriteLiteral(@"          var url = phonepeResponse.data.instrumentResponse.redirectInfo.url;

                    window.open(url);
                    //window.location=(url);
                    scheduleStatusChecks();
                    // Handle the data received from the server
                },
                error: function (error) {
                    // Handle errors, if any
                    console.error(error);
                }
            });


        /*});*/

        function scheduleStatusChecks() {
            // Initial check after 20-25 seconds
            setTimeout(function () {
                $('#btnPayment').text('Checking Payment Status...');

                checkPhonePeStatus();

                // Schedule checks ""Every 3 seconds once for the next 30 seconds""
                //var intervalCount = 0;
                intervalId = setInterval(function () {
                    checkPhonePeStatus();
                    intervalCount++;

                    if (inter");
            WriteLiteral(@"valCount >= 10) {
                        clearInterval(intervalId); // Stop after 30 seconds (10 intervals)
                    }
                }, 3000);
            }, 20000 + Math.random() * 5000); // Random delay within the specified range
        }

        function checkPhonePeStatus() {


            $.ajax({
                url: ""/Home/CheckPaymentStatus"", // Replace with your controller and action names
                type: ""POST"", // Change to POST to send data in the request body
                dataType: ""json"",
                // Convert the object to JSON
                contentType: ""application/json"", // Set the content type
                success: function (res) {
                  
                    if (res == 'Your payment is successful.') {
                        clearInterval(intervalId);
                        $.ajax({
                            type: ""POST"",
                            url: ""../Home/paymentsuccess"",
                            data: {
  ");
            WriteLiteral(@"                              
                                
                            },
                           
                            success: function (response) {
                               
                                window.location.href = ""/home/registerSee"";
                                //window.location.href = 'https://www.kbc40.com';
                       
                            }
                        });
                        
                    }
                    else if (res.message == 'Verification failed') {
                        alert('PAYMENT ERROR');
                    }


                },
                error: function (error) {
                    // Handle errors, if any
                    console.error(error);
                }
            });
        }
    });


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
