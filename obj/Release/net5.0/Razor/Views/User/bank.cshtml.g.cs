#pragma checksum "D:\all project\kbc40\Views\User\bank.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b5ea6f8ce281ffc256d5cd555bc057db0ec850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_bank), @"mvc.1.0.view", @"/Views/User/bank.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b5ea6f8ce281ffc256d5cd555bc057db0ec850", @"/Views/User/bank.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_bank : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.kycmodel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("verificationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "bank", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "user", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\all project\kbc40\Views\User\bank.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .radi {
        border-radius: 20px;
    }

    #verifyButton {
        padding: 10px 20px;
        font-size: 16px;
        cursor: pointer;
        background-color: #f0f0f0;
        border: 1px solid #ccc;
        border-radius: 5px;
    }

        #verifyButton.verified {
            background-color: green;
            color: white;
        }

    #panverify {
        padding: 10px 20px;
        font-size: 16px;
        cursor: pointer;
        background-color: #f0f0f0;
        border: 1px solid #ccc;
        border-radius: 5px;
    }

        #panverify.verified {
            background-color: green;
            color: white;
        }

    #adhverify {
        padding: 10px 20px;
        font-size: 16px;
        cursor: pointer;
        background-color: #f0f0f0;
        border: 1px solid #ccc;
        border-radius: 5px;
    }

        #adhverify.verified {
            background-color: green;
            color: white;
        }


   

 ");
            WriteLiteral(@"   /* The Close Button */
   
</style>

<div class=""content-wrapper"">
    <section class=""content"">
        <div class=""row"">
            <div class=""col-xl-12"">
                <div class=""card-box"">
                    <span class=""header-title m-t-0"" id=""result"" runat=""server"" style=""color:#017627;""></span>
                    <br />
                    <div>
                        <div>
                            <div class=""card-box"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b5ea6f8ce281ffc256d5cd555bc057db0ec8506504", async() => {
                WriteLiteral("\r\n                                    <h4 class=\"header-title mb-4\">Bank Information</h4>\r\n                                    <p class=\"header-title mb-4\" style=\"color:red;\">");
#nullable restore
#line 73 "D:\all project\kbc40\Views\User\bank.cshtml"
                                                                               Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                    <div class=""form-row"">

                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""accountno"">Account No</label>
                                            <input class=""form-control radi"" type=""text"" id=""accountno"" name=""accountno""");
                BeginWriteAttribute("value", " value=\"", 2316, "\"", 2340, 1);
#nullable restore
#line 78 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 2324, Model.accountno, 2324, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />
                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""ifsc"">IFSC</label>
                                            <input class=""form-control radi"" type=""text"" id=""ifsc"" name=""ifsc""");
                BeginWriteAttribute("value", " value=\"", 2686, "\"", 2705, 1);
#nullable restore
#line 82 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 2694, Model.ifsc, 2694, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />

                                        </div>
                                        <div class=""form-group col-md-12"">
                                            <button id=""verifyButton"">Account No Verify</button>
                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""accountno"">Account Holder Name</label>
                                            <input class=""form-control radi"" type=""text"" id=""accountno"" name=""AccountHolderName""");
                BeginWriteAttribute("value", " value=\"", 3313, "\"", 3345, 1);
#nullable restore
#line 90 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 3321, Model.AccountHolderName, 3321, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />
                                        </div>

                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""bankname"">Bank Name</label>
                                            <input class=""form-control radi"" type=""text"" id=""bankname"" name=""bankname""");
                BeginWriteAttribute("value", " value=\"", 3710, "\"", 3733, 1);
#nullable restore
#line 95 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 3718, Model.bankname, 3718, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />

                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""branch"">Branch</label>
                                            <input class=""form-control radi"" type=""text"" id=""branch"" name=""branch""");
                BeginWriteAttribute("value", " value=\"", 4089, "\"", 4110, 1);
#nullable restore
#line 100 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 4097, Model.branch, 4097, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />

                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""bankname"">City</label>
                                            <input class=""form-control radi"" type=""text"" id=""bankname"" name=""city""");
                BeginWriteAttribute("value", " value=\"", 4466, "\"", 4485, 1);
#nullable restore
#line 105 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 4474, Model.city, 4474, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />

                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""branch"">State</label>
                                            <input class=""form-control radi"" type=""text"" name=""state""");
                BeginWriteAttribute("value", " value=\"", 4827, "\"", 4847, 1);
#nullable restore
#line 110 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 4835, Model.state, 4835, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />

                                        </div>

                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""uploadadhar"">Pan Card</label>
                                            <input type=""file"" id=""panup"" name=""file1""");
                BeginWriteAttribute("value", " value=\"", 5184, "\"", 5206, 1);
#nullable restore
#line 116 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 5192, Model.pancard, 5192, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 5269, "\"", 5289, 1);
#nullable restore
#line 117 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 5275, Model.pancard, 5275, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""height: 260px;"" />
                                        </div>
                                        <div class=""form-group col-md-12"">
                                            <button id=""panverify"">Pancard Verify</button>
                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""accountno"">Pan Card No</label>
                                            <input class=""form-control radi"" type=""text"" id=""pan"" name=""pannumbr""");
                BeginWriteAttribute("value", " value=\"", 5880, "\"", 5903, 1);
#nullable restore
#line 124 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 5888, Model.pannumbr, 5888, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />
                                        </div>

                                        <div class=""form-group col-md-6"">

                                        </div>

                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""uploadadhar"">Adhaar Front upload</label>
                                            <input type=""file"" id=""adhf"" name=""file2""");
                BeginWriteAttribute("value", " value=\"", 6375, "\"", 6400, 1);
#nullable restore
#line 133 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 6383, Model.adharfront, 6383, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 6463, "\"", 6486, 1);
#nullable restore
#line 134 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 6469, Model.adharfront, 6469, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""height: 260px;"" />
                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""uploadadhar"">Adhaar Back upload</label>
                                            <input type=""file"" id=""adhb"" name=""file3""");
                BeginWriteAttribute("value", " value=\"", 6842, "\"", 6866, 1);
#nullable restore
#line 138 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 6850, Model.adharback, 6850, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 6929, "\"", 6951, 1);
#nullable restore
#line 139 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 6935, Model.adharback, 6935, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""height: 260px;"" />
                                        </div>

                                        <div class=""form-group col-md-12"">
                                            <button id=""adhverify"">Adhaar Card Verify</button>
                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""uploadadhar"">Passbook/Cheque</label>
                                            <input type=""file"" id=""uploadadhar"" name=""files""");
                BeginWriteAttribute("value", " value=\"", 7533, "\"", 7552, 1);
#nullable restore
#line 147 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 7541, Model.bank, 7541, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 7615, "\"", 7632, 1);
#nullable restore
#line 148 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 7621, Model.bank, 7621, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""height: 260px;"" />
                                        </div>

                                        <div class=""form-group col-md-6"">
                                            <label class=""control-label"" for=""accountno"">Adhaar Card No</label>
                                            <input class=""form-control radi"" type=""text""");
                BeginWriteAttribute("id", " id=\"", 7987, "\"", 7992, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"adharnumber\"");
                BeginWriteAttribute("value", " value=\"", 8012, "\"", 8038, 1);
#nullable restore
#line 153 "D:\all project\kbc40\Views\User\bank.cshtml"
WriteAttributeValue("", 8020, Model.adharnumber, 8020, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />
                                        </div>

                                        <div class=""form-group text-right m-b-0"">
                                            <input type=""submit"" value=""submit"" class=""btn btn-primary ""  />
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>
<div  id=""myModal"" class=""modal"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"" style=""background-color: #adc3da !important;"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Account Verification</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p id=""modalMessage""></p>
                <p id=""accountName""></p>
                <p id=""bankName""></p>
                <p id=""branch""></p>
                <p id=""city""></p>
                
            </div>
           
        </div>
    </div>
</div>
<div id=""myModals"" class=""modal"" tabindex=""-1"">");
            WriteLiteral(@"
    <div class=""modal-dialog"">
        <div class=""modal-content"" style=""background-color: #adc3da !important;"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Pan Card Verification</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Age: <span id=""age""></span></p>
                <p>Date of Birth: <span id=""dob""></span></p>
                <p>Father's Name: <span id=""father""></span></p>
                <p>Message: <span id=""message""></span></p>
                <p>Name: <span id=""name""></span></p>
                <p>PAN: <span id=""pan""></span></p>
                <p>PAN Type: <span id=""pan_type""></span></p>
                <p>Reference ID: <span id=""reference_id""></span></p>
                <p>Status: <span id=""status""></span></p>
                <p>Valid:");
            WriteLiteral(@" <span id=""valid""></span></p>
            </div>

        </div>
    </div>
</div>

<div id=""myModales"" class=""modal"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"" style=""background-color: #adc3da !important;"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Adhaar Card Verification</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Name: <span id=""names""></span></p>
                <p>Address: <span id=""address""></span></p>
                <p>Gender: <span id=""gender""></span></p>
                <p>Message: <span id=""messages""></span></p>
                <p>Pincode: <span id=""pincode""></span></p>
              
                <p>State: <span id=""state""></span></p>
                <p>Status: <span id=""statuss""></spa");
            WriteLiteral(@"n></p>
                <p>UID: <span id=""uid""></span></p>
                <p>Valid: <span id=""valids""></span></p>
                <p>Year of Birth: <span id=""yob""></span></p>
            </div>

        </div>
    </div>
</div>

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"">
    $(function () {
        var isAccountVerified = false;
        var isPanVerified = false;
        var isAdhaarVerified = false;

        function checkAndSubmitForm() {
            if (isAccountVerified && isPanVerified && isAdhaarVerified) {
                var submitButton = document.querySelector(""input[type='submit']"");
                submitButton.classList.remove(""btn-disabled"");
                submitButton.disabled = false;
            }
        }
        //$("".btn "").click(function () {
        $('#panverify').click(function () {
            var formData = new FormData();

            // Get the file from");
            WriteLiteral(@" the input element
            var fileInput = document.getElementById('panup');
            var file = fileInput.files[0];

            // Append the file and other data to the FormData object
            formData.append('file1', file);
            $.ajax({
                type: ""POST"",
                url: ""../user/pancardverify"",
                data: formData,
                processData: false, // Prevent jQuery from automatically transforming the data into a query string
                contentType: false, // Prevent jQuery from overriding the Content-Type header

                success: function (response) {
                    console.log(response);
                    $('#age').text(response.age);
                    $('#dob').text(response.dob);
                    $('#father').text(response.father);
                    $('#message').text(response.message);
                    $('#name').text(response.name);
                    $('#pan').text(response.pan);
                    $('#pan_type')");
            WriteLiteral(@".text(response.pan_type);
                    $('#reference_id').text(response.reference_id);
                    $('#status').text(response.status);
                    $('#valid').text(response.valid);
                    var f = response.status; 
                    if (f == ""VALID"") {
                        var button = document.getElementById(""panverify"");
                        button.classList.add(""verified"");
                        button.textContent = ""Verified"";
                        checkAndSubmitForm()
                    }
                    var modal = document.getElementById(""myModals"");

                    // Get the <span> element that closes the modal
                    var span = document.getElementsByClassName(""close"")[0];

                    // Open the modal
                    modal.style.display = ""block"";

                    // When the user clicks on <span> (x), close the modal
                    span.onclick = function () {
                        modal.s");
            WriteLiteral(@"tyle.display = ""none"";
                    }

                    // When the user clicks anywhere outside of the modal, close it
                    window.onclick = function (event) {
                        if (event.target == modal) {
                            modal.style.display = ""none"";
                        }
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
    });
</script>
<script type=""text/javascript"">
    $(function () {
        var isAccountVerified = false;
        var isPanVerified = false;
        var isAdhaarVerified = false;

        function checkAndSubmitForm() {
            if (isAccountVerified && isPanVerified && isAdhaarVerified) {
                var submitButton = document.querySelector(""input[type='submi");
            WriteLiteral(@"t']"");
                submitButton.classList.remove(""btn-disabled"");
                submitButton.disabled = false;
            }
        }
        //$("".btn "").click(function () {
        $('#adhverify').click(function () {
            var formData = new FormData();

            // Get the file from the input element
            var fileInput = document.getElementById('adhf');
            var fileInputs = document.getElementById('adhb');
             var file = fileInput.files[0];
             var files = fileInputs.files[0];

            // Append the file and other data to the FormData object
            formData.append('file2', file);
            formData.append('file3', files);
            $.ajax({
                type: ""POST"",
                url: ""../user/adhaarcardverify"",
                data: formData,
                processData: false, // Prevent jQuery from automatically transforming the data into a query string
                contentType: false, // Prevent jQuery from ov");
            WriteLiteral(@"erriding the Content-Type header

                success: function (response) {
                    console.log(response);
                    $('#names').text(response.name);
                    $('#address').text(response.address);
                    $('#gender').text(response.gender);
                    $('#messages').text(response.message);
                    $('#pincode').text(response.pincode);
                   
                    $('#state').text(response.state);
                    $('#statuss').text(response.status);
                    $('#uid').text(response.uid);
                    $('#valids').text(response.valid);
                    $('#yob').text(response.yob);
                    var f = response.status;
                    if (f == ""VALID"") {
                        var button = document.getElementById(""adhverify"");
                        button.classList.add(""verified"");
                        button.textContent = ""Verified"";
                        checkAndSubmitForm();");
            WriteLiteral(@"
                    }
                    var modal = document.getElementById(""myModales"");

                    // Get the <span> element that closes the modal
                    var span = document.getElementsByClassName(""close"")[0];

                    // Open the modal
                    modal.style.display = ""block"";

                    // When the user clicks on <span> (x), close the modal
                    span.onclick = function () {
                        modal.style.display = ""none"";
                    }

                    // When the user clicks anywhere outside of the modal, close it
                    window.onclick = function (event) {
                        if (event.target == modal) {
                            modal.style.display = ""none"";
                        }
                    }
                },

                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (");
            WriteLiteral(@"response) {
                    alert(response.responseText);
                }
            });
        });
    });
</script>
<script type=""text/javascript"">
    $(function () {
        var isAccountVerified = false;
        var isPanVerified = false;
        var isAdhaarVerified = false;

        function checkAndSubmitForm() {
            if (isAccountVerified && isPanVerified && isAdhaarVerified) {
                var submitButton = document.querySelector(""input[type='submit']"");
                submitButton.classList.remove(""btn-disabled"");
                submitButton.disabled = false;
            }
        }

        $('#verifyButton').click(function () {
            $.ajax({
                type: ""POST"",
                url: ""../user/accountverify"",
                data: {
                    ""accountno"": $(""#accountno"").val(),
                    ""ifsc"": $(""#ifsc"").val()
                },
                success: function (response) {
                    console.log(resp");
            WriteLiteral(@"onse);
                    const nameAtBank = response.data.nameAtBank;
                    const bankName = response.data.bankName;
                    const branch = response.data.branch;
                    const city = response.data.city;

                    const message = response.message;

                    // Display the extracted values in the modal
                    document.getElementById('modalMessage').textContent = message;
                    document.getElementById('accountName').textContent = `Account Holder: ${nameAtBank}`;
                    document.getElementById('bankName').textContent = `Bank Name: ${bankName}`;
                    document.getElementById('branch').textContent = `Branch: ${branch}`;
                    document.getElementById('city').textContent = `City: ${city}`;
                    var f = response.accountStatus;
                    if (f == ""VALID"") {
                        var button = document.getElementById(""verifyButton"");
                ");
            WriteLiteral(@"        button.classList.add(""verified"");
                        button.textContent = ""Verified"";
                        isAccountVerified = true;
                        checkAndSubmitForm();
                    }
                    // Get the modal
                    var modal = document.getElementById(""myModal"");

                    // Get the <span> element that closes the modal
                    var span = document.getElementsByClassName(""close"")[0];

                    // Open the modal
                    modal.style.display = ""block"";

                    // When the user clicks on <span> (x), close the modal
                    span.onclick = function () {
                        modal.style.display = ""none"";
                    }

                    // When the user clicks anywhere outside of the modal, close it
                    window.onclick = function (event) {
                        if (event.target == modal) {
                            modal.style.display = ");
            WriteLiteral(@"""none"";
                        }
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
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.kycmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
