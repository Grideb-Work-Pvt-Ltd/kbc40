#pragma checksum "D:\all project\kbc40\Views\User\Coupon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4205d0c4a8aa24f50f6e4ff87859bbc56d87c5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Coupon), @"mvc.1.0.view", @"/Views/User/Coupon.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4205d0c4a8aa24f50f6e4ff87859bbc56d87c5b", @"/Views/User/Coupon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ddd90587b56cc8092654fa9aa92c8f2663dadc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Coupon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<forex.Models.walletmodel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\all project\kbc40\Views\User\Coupon.cshtml"
  
    ViewData["Title"] = "coupon";
    Layout = "~/Views/Shared/_Layoutuser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    content-header {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        height: 100vh;
        margin: 0;
    }

    #couponContainer {
        position: relative;
        width: 350px; /* Set the width of your coupon container */
        height: 350px; /* Set the height of your coupon container */
        overflow: hidden;
    }

    #hiddenContent {
");
            WriteLiteral(@"        background-size: cover;
        width: 100%;
        height: 100%;
        position: absolute;
        top: 0;
        left: 0;
    }

    #scratch {
        position: absolute;
        top: 0;
        left: 0;
        z-index: 1;
    }

    #counts {
        margin-top: 10px;
        text-align: center;
    }



    #couponOverlay {
        background-color: #f00; /* Set your coupon color here */
        width: 100%;
        height: 100%;
        position: absolute;
        top: 0;
        left: 0;
        transition: background-color 0.5s; /* Adjust the transition duration as needed */
    }

    #couponContainer:hover #hiddenImage {
        opacity: 1;
    }

    #couponContainer:hover #couponOverlay {
        background-color: transparent;
    }
</style>



<div class=""content-wrapper"" style=""min-height: 333px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row");
            WriteLiteral(@" mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0""></h1>
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
    <section class=""content"">

        <div class=""container-fluid"">

            <div id=""couponContainer"">
                <canvas id=""scratch"" width=""350"" height=""350""></canvas>
                <div class=""ml-5"" id=""hiddenContent"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 2460, "\"", 2476, 1);
#nullable restore
#line 95 "D:\all project\kbc40\Views\User\Coupon.cshtml"
WriteAttributeValue("", 2466, Model.img, 2466, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Hidden Image"">
                    <!-- Add your hidden image or content here -->
                </div>
            </div>
            <div id=""counts"" hidden>
                <p>Gray Count: <span id=""gray-count"">0</span></p>

                <input type=""text"" value=""0"" id=""erase-count"" />
                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 2818, "\"", 2838, 1);
#nullable restore
#line 103 "D:\all project\kbc40\Views\User\Coupon.cshtml"
WriteAttributeValue("", 2826, Model.Index, 2826, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"index\" />\r\n                <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2889, "\"", 2908, 1);
#nullable restore
#line 104 "D:\all project\kbc40\Views\User\Coupon.cshtml"
WriteAttributeValue("", 2897, Model.type, 2897, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"type\" />\r\n                <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2958, "\"", 2978, 1);
#nullable restore
#line 105 "D:\all project\kbc40\Views\User\Coupon.cshtml"
WriteAttributeValue("", 2966, Model.value, 2966, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""value"" />
                <input type=""text"" value=""0"" id=""txt"" />

            </div>



        </div>
    </section>
</div>



<script>
    (function () {
        'use strict';

        var canvas = document.getElementById('scratch'),
            context = canvas.getContext('2d');

        // default value
        context.globalCompositeOperation = 'source-over';

        //----------------------------------------------------------------------------

        var x, y, radius;

        x = y = radius = 350 / 2;

        // fill circle
        context.beginPath();
        context.fillStyle = '#000fff';
        context.rect(0, 0, 350, 350);
        context.fill();

        //----------------------------------------------------------------------------

        var isDrag = false;

        function clearArc(x, y) {
            context.globalCompositeOperation = 'destination-out';
            context.beginPath();
            context.arc(x, y, 50, 0, Math.PI * 2, fal");
            WriteLiteral(@"se);
            context.fill();
        }

        function handleMouseDown(event) {
            isDrag = true;
            clearArc(event.clientX - canvas.getBoundingClientRect().left, event.clientY - canvas.getBoundingClientRect().top);
            judgeVisible();
        }

        function handleMouseMove(event) {
            if (!isDrag) {
                return;
            }

            clearArc(event.clientX - canvas.getBoundingClientRect().left, event.clientY - canvas.getBoundingClientRect().top);
            judgeVisible();
        }

        function handleMouseUp() {
            isDrag = false;
        }

        function handleMouseLeave() {
            isDrag = false;
        }

        canvas.addEventListener('mousedown', handleMouseDown, false);
        canvas.addEventListener('mousemove', handleMouseMove, false);
        canvas.addEventListener('mouseup', handleMouseUp, false);
        canvas.addEventListener('mouseleave', handleMouseLeave, false);

        /");
            WriteLiteral(@"/----------------------------------------------------------------------------

        function handleTouchStart(event) {
            if (event.targetTouches.length !== 1) {
                return;
            }

            event.preventDefault();
            isDrag = true;
            clearArc(event.targetTouches[0].clientX - canvas.getBoundingClientRect().left, event.targetTouches[0].clientY - canvas.getBoundingClientRect().top);
            judgeVisible();
        }

        function handleTouchMove(event) {
            if (!isDrag || event.targetTouches.length !== 1) {
                return;
            }

            event.preventDefault();
            clearArc(event.targetTouches[0].clientX - canvas.getBoundingClientRect().left, event.targetTouches[0].clientY - canvas.getBoundingClientRect().top);
            judgeVisible();
        }

        function handleTouchEnd() {
            isDrag = false;
        }

        canvas.addEventListener('touchstart', handleTouchStart, fa");
            WriteLiteral(@"lse);
        canvas.addEventListener('touchmove', handleTouchMove, false);
        canvas.addEventListener('touchend', handleTouchEnd, false);

        //----------------------------------------------------------------------------

        function judgeVisible() {
            var imageData = context.getImageData(0, 0, 350, 350),
                pixels = imageData.data,
                result = {},
                i, len;

            // count alpha values
            for (i = 3, len = pixels.length; i < len; i += 4) {
                result[pixels[i]] || (result[pixels[i]] = 0);
                result[pixels[i]]++;
            }

            document.getElementById('gray-count').innerHTML = result[255];
            document.getElementById('erase-count').value = result[0];

            if (result[0] > 82945) {
                var d = $(""#txt"").val();
                if (d == 0) {
                    $(""#txt"").val(1);

                    // perform the ajax request here
           ");
            WriteLiteral(@"         $.ajax({
                        type: ""post"",
                        url: ""../user/coupon1"", // Replace with your URL
                        data: {
                            ""index"": $(""#index"").val(),
                            ""type"": $(""#type"").val(),
                            ""value"": $(""#value"").val(),
                        },
                        success: function (response) {
                            if (response === ""bj"") {
                                window.location = ""/user/Couponaddress"";
                            } else {
                                window.location = ""/user/couponlist"";
                            }
                        },
                        error: function (response) {
                            alert(response.responsetext);
                        }
                    });
                }
            }
        }

        document.addEventListener('DOMContentLoaded', judgeVisible, false);
    })();
</script>");
            WriteLiteral("\n<script type=\"text/javascript\" src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js\"></script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<forex.Models.walletmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
