#pragma checksum "D:\all project\kbc40\Views\Admin\greenwalletsummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9752f8b6dfe8c1846101c177c5da078d8b390b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_greenwalletsummary), @"mvc.1.0.view", @"/Views/Admin/greenwalletsummary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9752f8b6dfe8c1846101c177c5da078d8b390b1", @"/Views/Admin/greenwalletsummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_greenwalletsummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\all project\kbc40\Views\Admin\greenwalletsummary.cshtml"
  
       ViewData["Title"] = "greenwalletsummary";
       Layout = "~/Views/Shared/_Layoutadmin.cshtml";

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
            <h1 class=""m-0"">Green Wallet Summary</h1>
          </div><!-- /.col -->
          <div class=""col-sm-6"">
            <ol class=""breadcrumb float-sm-right"">
              <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
              <li class=""breadcrumb-item active"">Green Wallet</li>
            </ol>
          </div><!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
 
    <!-- Main ");
            WriteLiteral(@"content -->
    <section class=""content"">
    
     <div class=""container"">
        <div class=""row"">
            
            <div class=""col-lg-12 mt-3"">  
              	<div class=""table-responsive table-rounds"">
					<table id=""mytable"" class=""table table-hover table-striped table-border-whole table-bordered table-responsive-sm"" style=""font-size:14px;"">
					   <thead class=""table-light-head"">
					        <tr class=""table-border"">
					          <th scope=""col"" class=""table-border"">Index</th>
					          <th scope=""col"" class=""table-border"">User Id</th>					   
					          <th scope=""col"" class=""table-border"">Amout</th>
					          <th scope=""col"" class=""table-border"">Details</th>
                              <th scope=""col"" class=""table-border"">Cr/Dr</th>
                              <th scope=""col"" class=""table-border"">Date</th>
                          
                           
					       </tr>                        
					     </thead>
					      <tbody class=""ta");
            WriteLiteral(@"ble-details"">
					       <tr>
					          <th scope=""row"">1</th>		      				      			         
					         <th scope=""row"">Rajesh</th>
                             <th scope=""row"">rajesh@123</th>
                             <th scope=""row"">9315025688</th>
                              <th scope=""row"">proper</th>
                              <th scope=""row"">U12345</th>
                     
                           
					        </tr>
                           <tr>
					          <th scope=""row"">2</th>					        				        
                              <th scope=""row"">Mohan</th>
                              <th scope=""row"">puneetkumar611</th>
                              <th scope=""row"">558936147</th>
                              <th scope=""row"">proper</th>
                              <th scope=""row"">u23412</th>
                   
                          
					        </tr>
                                <tr>
					          <th scope=""row"">3</th>					        				  ");
            WriteLiteral(@"      
                              <th scope=""row"">Mohan</th>
                              <th scope=""row"">puneetkumar611</th>
                              <th scope=""row"">558936147</th>
                              <th scope=""row"">proper</th>
                              <th scope=""row"">u23412</th>
                    
                         
					        </tr>
                            <tr>
					          <th scope=""row"">4</th>					        				        
                              <th scope=""row"">Mohan</th>
                              <th scope=""row"">puneetkumar611</th>
                              <th scope=""row"">558936147</th>
                              <th scope=""row"">proper</th>
                              <th scope=""row"">u23412</th>
                      
                            
					        </tr>
                            
                             
                             		        					          
					      </tbody>
					  </table>
				</div>");
            WriteLiteral("       \r\n            </div>\r\n         </div>\r\n      </div>\r\n   </section> \r\n</div>\r\n   \r\n        \r\n    \r\n \r\n\r\n    ");
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
