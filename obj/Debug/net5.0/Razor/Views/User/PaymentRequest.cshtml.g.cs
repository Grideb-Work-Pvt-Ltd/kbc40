#pragma checksum "D:\KBC40MVCCore\Views\User\PaymentRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3207b389573e62f4d1d43927ccd9b6d9ecbb61b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_PaymentRequest), @"mvc.1.0.view", @"/Views/User/PaymentRequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3207b389573e62f4d1d43927ccd9b6d9ecbb61b", @"/Views/User/PaymentRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_PaymentRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\KBC40MVCCore\Views\User\PaymentRequest.cshtml"
  
       ViewData["Title"] = "PaymentRequest";
       Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    table.dataTable tbody tr {
    background-color: #272672;

}
label{
    color: #fff;
}
div#mytable_info {
    color: #fff;
}
a#mytable_previous {
    color: #fff!important;
}
a#mytable_next {
     color: #fff!important;
}

input[type=""search""] {
    color: #fff;
}

</style>

        
<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
      <div class=""container-fluid"">
        <div class=""row mb-2"">
          <div class=""col-sm-6"">
            <h1 class=""m-0"">Payment Request</h1>
          </div><!-- /.col -->
          <div class=""col-sm-6"">
            <ol class=""breadcrumb float-sm-right"">
              <li class=""breadcrumb-item""><a href=""../User/dashboard"">Business Panel</a></li>
             
            </ol>
          </div><!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
 
    <!-- Main content -->
    <section class=""c");
            WriteLiteral("ontent\">\r\n       <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12\">             \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3207b389573e62f4d1d43927ccd9b6d9ecbb61b4639", async() => {
                WriteLiteral(@"
                      <div class=""form-group"">
                        <label for=""formGroupExampleInput"">Total Balance</label>
                        <input type=""text"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""$"" style=""width: 40vh;"">
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
            </div>
        </div>
     <div class=""container"">
        <div class=""row"">           
            <div class=""col-lg-12 mt-3"">  
              	<div class=""table-responsive table-rounds"">
					<table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"">
					   <thead class=""table-light-head"">
					        <tr class=""table-border"">
					          <th scope=""col"" class=""table-border"">Index</th>
                                <th scope=""col"" class=""table-border"">$ Fund</th>	
					          <th scope=""col"" class=""table-border"">Details</th>					   					        				        
                              <th scope=""col"" class=""table-border"">Cr/Dr</th>
                              <th scope=""col"" class=""table-border"">Date</th>
                            
                           
					       </tr>                        
					     </thead>
					      <tbody class=""table-details"">
					       <tr>
		");
            WriteLiteral(@"			         <th scope=""row"">1</th>		      				      			         
					         <th scope=""row"">Rajesh</th>
                             <th scope=""row"">rajesh@123</th>
                             <th scope=""row"">9315025688</th>
                              <th scope=""row"">proper</th>
                            
                              
					        </tr>
                           <tr>
					          <th scope=""row"">2</th>					        				        
                              <th scope=""row"">Mohan</th>
                              <th scope=""row"">puneetkumar611</th>
                              <th scope=""row"">558936147</th>
                              <th scope=""row"">proper</th>
                          
                                                                 
					        </tr>
                                <tr>
					          <th scope=""row"">3</th>					        				        
                              <th scope=""row"">Mohan</th>
                              <t");
            WriteLiteral(@"h scope=""row"">puneetkumar611</th>
                              <th scope=""row"">558936147</th>
                              <th scope=""row"">proper</th>
                             
                                                                 
					        </tr>
                            <tr>
					          <th scope=""row"">4</th>					        				        
                              <th scope=""row"">Mohan</th>
                              <th scope=""row"">puneetkumar611</th>
                              <th scope=""row"">558936147</th>
                              <th scope=""row"">proper</th>
                            
                                                                    
					        </tr>
                            
                             
                             		        					          
					      </tbody>
					  </table>
				</div>       
            </div>
         </div>
      </div>
   </section> 
</div>
   
        
    
 

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
