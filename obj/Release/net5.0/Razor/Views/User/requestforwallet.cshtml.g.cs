#pragma checksum "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31ede8ca6b6b0445b0852226539290e876e47e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_requestforwallet), @"mvc.1.0.view", @"/Views/User/requestforwallet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31ede8ca6b6b0445b0852226539290e876e47e94", @"/Views/User/requestforwallet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_requestforwallet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.kycmodellist>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "requestforwallet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "user", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
  
    Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""content-wrapper"">
    <section class=""content"">

        <section>
            <h1 class=""h1-12"">Fund Request</h1>
            <!--for demo wrap-->
            <div class=""tbl-header"">
                <div id=""name"" style=""color:red;""></div>
                <table class=""table table-responsive-sm"" cellpadding=""0"" cellspacing=""0"" border=""0"">
                    <thead class=""bg-dark"" style="" color:#fff;"">
                        <tr>
                            <th>Index</th>
                            <th>Userid</th>
                            <th> KBC Amount</th>
                            <th> Needan Amount</th>
                            <th>Transaction Id</th>
                            <th>Image</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
                         foreach (var item in Model.kyclist)
                        {
                            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th class=\"row-incom\">");
#nullable restore
#line 36 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td id=\"Userid\">");
#nullable restore
#line 37 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
                                       Write(item.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td id=\"amount\">");
#nullable restore
#line 38 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
                                       Write(item.kamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td id=\"amount\">");
#nullable restore
#line 39 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
                                       Write(item.namount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td id=\"transection\">");
#nullable restore
#line 40 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
                                            Write(item.transection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 1604, "\"", 1621, 1);
#nullable restore
#line 41 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
WriteAttributeValue("", 1611, item.bank, 1611, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1627, "\"", 1643, 1);
#nullable restore
#line 41 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
WriteAttributeValue("", 1633, item.bank, 1633, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:30px;\"></a></td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31ede8ca6b6b0445b0852226539290e876e47e947680", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1866, "\"", 1887, 1);
#nullable restore
#line 44 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
WriteAttributeValue("", 1874, item.indexid, 1874, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                                    <button type=\"submit\" class=\"btn btn-info\"> Submit </button>\r\n                                ");
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
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 50 "D:\KBC40MVCCore\Views\User\requestforwallet.cshtml"
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
