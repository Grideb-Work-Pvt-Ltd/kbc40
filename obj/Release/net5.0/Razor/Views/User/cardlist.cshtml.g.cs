#pragma checksum "D:\KBC40MVCCore\Views\User\cardlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "285b8d1774785db82da9b745a042cfddd8bcee95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_cardlist), @"mvc.1.0.view", @"/Views/User/cardlist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"285b8d1774785db82da9b745a042cfddd8bcee95", @"/Views/User/cardlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_cardlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.ProductAddModelList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delcard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "user", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
  
    ViewData["Title"] = "shop";
    Layout = "~/views/Shared/_Layoutuser.cshtml";

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
                    <h1 class=""m-0""></h1>
                </div><!-- /.col -->
                <div class=""col-sm-6""></div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Total</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 34 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
                     foreach (var item in Model.ProductAddModelVarriable)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 37 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
                           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <span");
            BeginWriteAttribute("id", " id=\"", 1332, "\"", 1352, 2);
            WriteAttributeValue("", 1337, "price_", 1337, 6, true);
#nullable restore
#line 39 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
WriteAttributeValue("", 1343, item.pid, 1343, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
                                                      Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "285b8d1774785db82da9b745a042cfddd8bcee956541", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 1616, "\"", 1633, 1);
#nullable restore
#line 43 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
WriteAttributeValue("", 1624, item.pid, 1624, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1696, "\"", 1743, 4);
                WriteAttributeValue("", 1706, "updatePrice(\'", 1706, 13, true);
#nullable restore
#line 44 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
WriteAttributeValue("", 1719, item.pid, 1719, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1728, "\',", 1728, 2, true);
                WriteAttributeValue(" ", 1730, "\'increment\')", 1731, 13, true);
                EndWriteAttribute();
                WriteLiteral(">+</button>\r\n                                    <span");
                BeginWriteAttribute("id", " id=\"", 1798, "\"", 1821, 2);
                WriteAttributeValue("", 1803, "quantity_", 1803, 9, true);
#nullable restore
#line 45 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
WriteAttributeValue("", 1812, item.pid, 1812, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 45 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
                                                             Write(item.quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1903, "\"", 1950, 4);
                WriteAttributeValue("", 1913, "updatePrice(\'", 1913, 13, true);
#nullable restore
#line 46 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
WriteAttributeValue("", 1926, item.pid, 1926, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1935, "\',", 1935, 2, true);
                WriteAttributeValue(" ", 1937, "\'decrement\')", 1938, 13, true);
                EndWriteAttribute();
                WriteLiteral(">-</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onsubmit", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1505, "return", 1505, 6, true);
            AddHtmlAttributeValue(" ", 1511, "updateQuantity(\'", 1512, 17, true);
#nullable restore
#line 42 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
AddHtmlAttributeValue("", 1528, item.pid, 1528, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1537, "\')", 1537, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td");
            BeginWriteAttribute("id", " id=\"", 2071, "\"", 2091, 2);
            WriteAttributeValue("", 2076, "total_", 2076, 6, true);
#nullable restore
#line 49 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
WriteAttributeValue("", 2082, item.pid, 2082, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
                                                Write(Convert.ToDecimal(item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "285b8d1774785db82da9b745a042cfddd8bcee9511845", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2325, "\"", 2346, 1);
#nullable restore
#line 52 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
WriteAttributeValue("", 2333, item.indexid, 2333, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                                    <button type=\"submit\" class=\"btn btn-danger\">Remove</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 57 "D:\KBC40MVCCore\Views\User\cardlist.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- Add a separate row for the final total -->
                    <tr>
                        <td colspan=""3"">Total</td>
                        <td id=""finalTotal""></td>
                        <td>

                            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"" id=""buy"">
                                Buy
                            </button>
");
            WriteLiteral(@"
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        

        <!-- Modal -->
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" style=""color:white !important"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Address</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "285b8d1774785db82da9b745a042cfddd8bcee9515842", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label>Name</label>
                                <input type=""text"" class=""form-control"" id=""name"" readonly />
                            </div>
                            <div class=""form-group"">
                                <label>Mobile No</label>
                                <input type=""text"" class=""form-control""id=""mobile""readonly />
                            </div>
                            <div class=""form-group"">
                                <label>Address</label>
                                <textarea class=""form-control"" rows=""3"" id=""address""></textarea>
                            </div>
                            <div class=""form-group"">
                                <label>City</label>
                                <input type=""text"" class=""form-control""id=""city"" />
                            </div>
                            <div class=""form-group"">
               ");
                WriteLiteral(@"                 <label>State</label>
                                <input type=""text"" class=""form-control"" id=""state"" />
                            </div>
                            <div class=""form-group"">
                                <label>Pincode</label>
                                <input type=""text"" class=""form-control""id=""pin"" />
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"" id=""udadd"">Save
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>

<script src=""https://code.jquery.com/jquery-3.6.4.min.js""></script>

<script>
    function updatePrice(productId, action) {
        var priceElement = document.getElementById('price_' + productId);
        var quantityElement = document.getElementById('quantity_' + productId);
        var totalElement = document.getElementById('total_' + productId);
        var finalTotalElement = document.getElementById('finalTotal');

        var price = parseFloat(priceElement.innerText);
        var quantity = parseInt(quantityElement.innerText);

        if (action === 'inc");
            WriteLiteral(@"rement') {
            quantity++;
        } else if (action === 'decrement' && quantity > 1) {
            quantity--;
        }

        quantityElement.innerText = quantity;
        totalElement.innerText = (price * quantity).toFixed(2);

        // Calculate and update the final total
        updateFinalTotal();
    }

    function updateFinalTotal() {
        var finalTotalElement = document.getElementById('finalTotal');
        var totalElements = document.querySelectorAll('[id^=""total_""]');
        var finalTotal = 0;

        totalElements.forEach(function (totalElement) {
            finalTotal += parseFloat(totalElement.innerText);
        });

        finalTotalElement.innerText = finalTotal.toFixed(2);
    }
    window.onload = function () {
        updateFinalTotal();
    };
    // Buy button click event
    function buyproduct() {
        // Get all product data from the table
        var productData = [];
        $(""tbody tr"").each(function () {
            var q");
            WriteLiteral(@"uantityElement = $(this).find('[id^=""quantity_""]');
            var productId = quantityElement.length > 0 ? quantityElement.attr('id').split(""_"")[1] : null;

            // Check if productId is defined before proceeding
            if (productId !== null) {
                var quantity = parseInt(quantityElement.text());
                var price = parseFloat($(this).find('[id^=""price_""]').text());

                // Check if quantity is a valid number before adding to productData
                if (!isNaN(quantity)) {
                    productData.push({ productId: productId, quantity: quantity, price: price });
                }
            }
        });

        // Get the final total
        var finalTotal = parseFloat($(""#finalTotal"").text());
        console.log(finalTotal);
        console.log(productData);

        // Make an AJAX call to send data to the server
      
        $.ajax({

            type: ""POST"",
            url: ""../user/buy"",
            data: {
     ");
            WriteLiteral(@"          
                ""products"": JSON.stringify(productData),
                ""finalTotal"": finalTotal
               
            },
            success: function (response) {
                
                alert(response);
                window.location.href='../user/shop'
            },

            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    }
</script>
<script>
    $(document).on(""click"", ""#buy"", function () {
       


        $.ajax({

            type: ""POST"",
            url: ""../user/findaddress"",
            data: {


            },
            success: function (response) {

                $('#name').val(response.name);
                $('#city').val(response.city);
                $('#mobile').val(response.mobile);
                $('#address').val(response.address);
                $('");
            WriteLiteral(@"#state').val(response.state);
                $('#pin').val(response.pin);
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
    $(document).on(""click"", ""#udadd"", function () {



        $.ajax({

            type: ""POST"",
            url: ""../user/updateaddress"",
            data: {
                ""city"": $(""#city"").val(),
                
                ""address"": $(""#address"").val(),
                ""state"": $(""#state"").val(),
                ""pin"": $(""#pin"").val(),
            },
            success: function (response) {
               
                buyproduct();
                //$(""#buyButton"").click();
               
            },

            failure: function (response) {
                alert(response.responseText);
            },
            e");
            WriteLiteral("rror: function (response) {\r\n                alert(response.responseText);\r\n            }\r\n        });\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.ProductAddModelList> Html { get; private set; }
    }
}
#pragma warning restore 1591
