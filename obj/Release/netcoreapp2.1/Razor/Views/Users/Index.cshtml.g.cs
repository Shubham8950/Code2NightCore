#pragma checksum "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "673099f9f349068e5dd730cf5f054d4347cb0d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 1 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Code2Night;

#line default
#line hidden
#line 6 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Code2Night.Models;

#line default
#line hidden
#line 7 "F:\Code2NightCore\Code2Night\Code2Night\Views\_ViewImports.cshtml"
using Code2Night.DAL.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"673099f9f349068e5dd730cf5f054d4347cb0d71", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Images/slider-3-slide-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("slidebg1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bgposition", new global::Microsoft.AspNetCore.Html.HtmlString("center top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bgfit", new global::Microsoft.AspNetCore.Html.HtmlString("cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bgrepeat", new global::Microsoft.AspNetCore.Html.HtmlString("no-repeat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/slider-3-slide-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(229, 584, true);
            WriteLiteral(@"
<!-- banner end -->
<!-- page-top start-->
<!-- ================ -->
<link href=""/plugins/rs-plugin/css/settings.css"" media=""screen"" rel=""stylesheet"">
<link href=""/plugins/rs-plugin/css/extralayers.css"" media=""screen"" rel=""stylesheet"">
<link href=""/plugins/magnific-popup/magnific-popup.css"" rel=""stylesheet"">
<link href=""/css/animations.css"" rel=""stylesheet"">
<link href=""/plugins/owl-carousel/owl.carousel.css"" rel=""stylesheet"">

<!-- Code2night core CSS file -->
<link href=""/css/style.css"" rel=""stylesheet"">

<!-- Style Switcher Styles (Remove these two lines) -->
");
            EndContext();
            BeginContext(950, 649, true);
            WriteLiteral(@"
<!-- Custom css -->
<link href=""/css/custom.css"" rel=""stylesheet"">
<div class=""banner"">

    <!-- slideshow start -->
    <!-- ================ -->
    <div class=""slideshow white-bg"">

        <!-- slider revolution start -->
        <!-- ================ -->
        <div class=""slider-banner-container"">
            <div class=""slider-banner-fullscreen"">
                <ul>
                    <!-- slide 1 start -->
                    <li data-transition=""fade"" data-slotamount=""7"" data-masterspeed=""1000"" data-saveperformance=""on"" data-title=""Slide 1"">

                        <!-- main image -->
                        ");
            EndContext();
            BeginContext(1599, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "673099f9f349068e5dd730cf5f054d4347cb0d717438", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1737, 1927, true);
            WriteLiteral(@"

                        <!-- Translucent background -->
                        <div class=""tp-caption light-translucent-bg""
                             data-x=""center""
                             data-y=""bottom""
                             data-speed=""800""
                             data-start=""0""
                             style=""background-color:rgba(255,255,255,0.3);"">
                        </div>

                        <!-- LAYER NR. 1 -->
                        <div class=""tp-caption very_large_text black sfl tp-resizeme""
                             data-x=""center""
                             data-y=""70""
                             data-speed=""600""
                             data-start=""0""
                             data-end=""10000""
                             data-endspeed=""600"">
                            Welcome To Code2Night
                        </div>

                        <!-- LAYER NR. 2 -->
                        <div class=""tp-caption sfr sma");
            WriteLiteral(@"ll_thin_dark text-center tp-resizeme""
                             data-x=""center""
                             data-y=""170""
                             data-speed=""600""
                             data-start=""0""
                             data-end=""10000""
                             data-endspeed=""600"">
                            Get Tutorials and Online Videos for tricks and problems related to programming in Asp.Net,SQl and MVC
                        </div>

                        <!-- LAYER NR. 3 -->
                        <div class=""tp-caption tp-resizeme sfl""
                             data-x=""center""
                             data-y=""350""
                             data-speed=""600""
                             data-start=""0""
                             data-end=""10000""
                             data-endspeed=""600"">
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3664, "\"", 3702, 1);
#line 83 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Index.cshtml"
WriteAttributeValue("", 3671, Url.Action("ContactUs","Blog"), 3671, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3703, 450, true);
            WriteLiteral(@" class=""btn btn-dark btn-lg"">Contact Us <i class=""fa fa-angle-double-right pl-10""></i></a>
                        </div>

                    </li>
                    <!-- slide 1 end -->
                    <!-- slide 2 start -->
                    <li data-transition=""fade"" data-slotamount=""7"" data-masterspeed=""1000"" data-saveperformance=""on"" data-title=""Slide 2"">

                        <!-- main image -->
                        ");
            EndContext();
            BeginContext(4153, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "673099f9f349068e5dd730cf5f054d4347cb0d7111820", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4291, 1904, true);
            WriteLiteral(@"

                        <!-- Translucent background -->
                        <div class=""tp-caption light-translucent-bg""
                             data-x=""center""
                             data-y=""bottom""
                             data-speed=""800""
                             data-start=""0""
                             style=""background-color:rgba(255,255,255,0.3);"">
                        </div>

                        <!-- LAYER NR. 1 -->
                        <div class=""tp-caption very_large_text black sfl tp-resizeme""
                             data-x=""center""
                             data-y=""70""
                             data-speed=""600""
                             data-start=""0""
                             data-end=""10000""
                             data-endspeed=""600"">
                            Welcome To Code2Night
                        </div>

                        <!-- LAYER NR. 2 -->
                        <div class=""tp-caption sfr sma");
            WriteLiteral(@"ll_thin_dark text-center tp-resizeme""
                             data-x=""center""
                             data-y=""170""
                             data-speed=""600""
                             data-start=""0""
                             data-end=""10000""
                             data-endspeed=""600"">
                            Share and Write your own Blogs Embed you tube videos and share your tutorials.
                        </div>

                        <!-- LAYER NR. 3 -->
                        <div class=""tp-caption sfl tp-resizeme""
                             data-x=""center""
                             data-y=""300""
                             data-speed=""600""
                             data-start=""0""
                             data-end=""10000""
                             data-endspeed=""600"">
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6195, "\"", 6229, 1);
#line 133 "F:\Code2NightCore\Code2Night\Code2Night\Views\Users\Index.cshtml"
WriteAttributeValue("", 6202, Url.Action("Blogs","Blog"), 6202, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6230, 1381, true);
            WriteLiteral(@" class=""btn btn-dark btn-lg"">Blogs <i class=""fa fa-angle-double-right pl-10""></i></a>
                        </div>

                    </li>
                    <!-- slide 2 end -->

                </ul>
            </div>
        </div>
        <!-- slider revolution end -->

    </div>
    <!-- slideshow end -->

</div>

<!-- page-top end -->
<!-- main-container start -->
<!-- ================ -->
<section class=""main-container default-bg"">

    <!-- main start -->
    <!-- ================ -->
    <div class=""main"">
        <div class=""container"">
            <div class=""call-to-action"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <blockquote class=""inline"">
                            <p class=""margin-clear"">Never study to be successful, study for self-efficiency. Don’t run behind success. Follow behind excellence, success will come all way behind you.</p>
                            <footer style=""color:white;font");
            WriteLiteral(@"-size:20px;""><cite title=""Source Title"">3 Idiots </cite></footer>
                        </blockquote>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- main end -->

</section>

<div class=""gray-bg text-muted footer-top clearfix"">
    <div class=""container"">
        <div class=""row"">
");
            EndContext();
            BeginContext(9143, 74, true);
            WriteLiteral("            \r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- section end -->\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.DAL.Common.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
