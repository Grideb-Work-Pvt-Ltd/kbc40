#pragma checksum "D:\all project\kbc40\Views\Admin\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "897c205a96235200bfc07da83f573ee1ca300bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Profile), @"mvc.1.0.view", @"/Views/Admin/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"897c205a96235200bfc07da83f573ee1ca300bf7", @"/Views/Admin/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 2 "D:\all project\kbc40\Views\Admin\Profile.cshtml"
  
       ViewData["Title"] = "Profile";
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
            <h1 class=""m-0"">Profile</h1>
          </div><!-- /.col -->
          <div class=""col-sm-6"">
            <ol class=""breadcrumb float-sm-right"">
              <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
              <li class=""breadcrumb-item active"">Direct Referral</li>
            </ol>
          </div><!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
 
    <!-- Main content -->
    <section class=""content"">
    
     <div class=""container"">
        <div class=""row"">            
            <div class=""col-lg-3"">  
              	     
            </div>
             <div class=""col-lg-6"">  
              	  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "897c205a96235200bfc07da83f573ee1ca300bf74366", async() => {
                WriteLiteral(@"
                  <div class=""form-group"">
                    <label for=""formGroupExampleInput"">Name</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""Name"">
                  </div>
                  <div class=""form-group"">
                    <label for=""formGroupExampleInput2"">Email</label>
                    <input type=""email"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""Email"" disabled>
                  </div>
                    <div class=""form-group"">
                    <label for=""formGroupExampleInput2"">Mobile</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""Mobile"" disabled>
                  </div>
                    <div class=""form-group"">
                    <label for=""formGroupExampleInput2"">Code</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""Code"" disabled>
                ");
                WriteLiteral(@"  </div>
                    <div class=""form-group"">
                    <label for=""formGroupExampleInput2"">Sponsor</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""Sponsor"" disabled>
                  </div>
                    <div class=""form-group"">
                    <label for=""formGroupExampleInput2"">Packege</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""Packege"" disabled>
                  </div>
                    <div class=""form-group"">
                    <label for=""formGroupExampleInput2"">D.O.A</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""D.O.A"" disabled>
                  </div>
                    <div class=""form-group"">
                    <label for=""formGroupExampleInput2"">Country</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""");
                WriteLiteral(@"Country"" disabled>
                  </div>
                    <div class=""form-group"">
                    <label for=""formGroupExampleInput2"">Wallet Address</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""Wallet Address"">
                  </div>
                   <div class=""form-group"">
                    
                    <button type=""button""  class=""btn btn"" id=""formGroupExampleInput2"" style=""background-image: linear-gradient(150deg, #8e8ebf 80%, #191951);""><i class=""nav-icon fa fa-edit""></i> Edit</button>
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
            WriteLiteral("   \r\n            </div>\r\n             <div class=\"col-lg-3\">  \r\n              \t     \r\n            </div>\r\n         </div>\r\n      </div>\r\n   </section> \r\n</div>\r\n   \r\n        \r\n    \r\n \r\n\r\n    ");
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
