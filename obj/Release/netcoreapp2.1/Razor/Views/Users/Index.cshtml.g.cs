#pragma checksum "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10ad36d6bf09bf783634a9e2e857836dc44d1bd6"
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
#line 1 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Code2Night;

#line default
#line hidden
#line 6 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Code2Night.Models;

#line default
#line hidden
#line 7 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Code2Night.DAL.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ad36d6bf09bf783634a9e2e857836dc44d1bd6", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Code2Night.DAL.Common.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(281, 584, true);
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
            BeginContext(1002, 71, true);
            WriteLiteral("\r\n<!-- Custom css -->\r\n<link href=\"/css/custom.css\" rel=\"stylesheet\">\r\n");
            EndContext();
            BeginContext(1542, 350, true);
            WriteLiteral(@"<section class=""main-container"" style=""padding: 0px 0px"">

    <div class=""container"">
        <div class=""row"">
            <div class=""main col-md-8"">
                <!-- page-title start -->
                <!-- ================ -->
                <h3 class=""page-title"">Latest Blog</h3>
                <div class=""separator-2""></div>
");
            EndContext();
#line 60 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                 foreach (var item in Model.OrderByDescending(x => x.Date))
                {

#line default
#line hidden
            BeginContext(1988, 332, true);
            WriteLiteral(@"                    <article class=""clearfix blogpost object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""200"">
                        <div class=""blogpost-body"">
                            <div class=""post-info"">
                                <span class=""day"">");
            EndContext();
            BeginContext(2321, 24, false);
#line 65 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                                             Write(item.Date.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(2345, 61, true);
            WriteLiteral("</span>\r\n                                <span class=\"month\">");
            EndContext();
            BeginContext(2407, 30, false);
#line 66 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                                               Write(item.Date.ToString("MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2437, 205, true);
            WriteLiteral("</span>\r\n                            </div>\r\n\r\n\r\n                            <div class=\"blogpost-content\">\r\n                                <header>\r\n                                    <h2 class=\"title\">");
            EndContext();
            BeginContext(2642, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10ad36d6bf09bf783634a9e2e857836dc44d1bd67902", async() => {
                BeginContext(2697, 10, false);
#line 72 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                                                                                                       Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2667, "~/Blog/MyBlog/", 2667, 14, true);
#line 72 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 2681, item.BlogUrl, 2681, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2711, 113, true);
            WriteLiteral("</h2>\r\n                                    <div class=\"submitted\"><i class=\"fa fa-user pr-5\"></i> by <a href=\"#\">");
            EndContext();
            BeginContext(2825, 15, false);
#line 73 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                                                                                                     Write(item.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(2840, 72, true);
            WriteLiteral("</a><a style=\"color: black;margin-left: 16px;\"><i class=\"fa fa-eye\"></i>");
            EndContext();
            BeginContext(2913, 14, false);
#line 73 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                                                                                                                                                                                             Write(item.TotalView);

#line default
#line hidden
            EndContext();
            BeginContext(2927, 127, true);
            WriteLiteral("</a></div>\r\n                                   \r\n                                </header>\r\n                                <p>");
            EndContext();
            BeginContext(3055, 21, false);
#line 76 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                              Write(item.BlogIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(3076, 108, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </article>\r\n");
            EndContext();
#line 81 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3203, 267, true);
            WriteLiteral(@"            </div>

            <aside class=""col-md-4"">
                <div class=""sidebar"">

                    <div class=""block clearfix"">
                        <h3 class=""title"">Top Trending</h3>
                        <div class=""separator""></div>
");
            EndContext();
#line 90 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                         foreach (var item in Model.OrderByDescending(x=> x.TotalView))
                        {

#line default
#line hidden
            BeginContext(3586, 157, true);
            WriteLiteral("                            <ul class=\"tweets\">\r\n                                <li>\r\n                                    <i class=\"fa fa-line-chart\"></i>\r\n");
            EndContext();
            BeginContext(3803, 53, true);
            WriteLiteral("                                    <p class=\"title\">");
            EndContext();
            BeginContext(3856, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10ad36d6bf09bf783634a9e2e857836dc44d1bd612746", async() => {
                BeginContext(3933, 10, false);
#line 96 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                                                                                                                            Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3903, "~/Blog/MyBlog/", 3903, 14, true);
#line 96 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 3917, item.BlogUrl, 3917, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3947, 84, true);
            WriteLiteral("</p>\r\n\r\n                                </li>\r\n\r\n                            </ul>\r\n");
            EndContext();
#line 101 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4058, 244, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"block clearfix\">\r\n                        <h3 class=\"title\">Featured Post</h3>\r\n                        <div class=\"separator\"></div>\r\n                        <div class=\"image-box\">\r\n");
            EndContext();
#line 107 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(4391, 116, true);
            WriteLiteral("                                <div class=\"image-box-body\">\r\n                                    <h3 class=\"title\">");
            EndContext();
            BeginContext(4507, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10ad36d6bf09bf783634a9e2e857836dc44d1bd615852", async() => {
                BeginContext(4562, 10, false);
#line 110 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                                                                                                       Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4532, "~/Blog/MyBlog/", 4532, 14, true);
#line 110 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 4546, item.BlogUrl, 4546, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4576, 88, true);
            WriteLiteral("</h3>\r\n                                    <p></p>\r\n                                    ");
            EndContext();
            BeginContext(4664, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10ad36d6bf09bf783634a9e2e857836dc44d1bd617924", async() => {
                BeginContext(4731, 22, true);
                WriteLiteral("<span>Read More</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4689, "~/Blog/MyBlog/", 4689, 14, true);
#line 112 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 4703, item.BlogUrl, 4703, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4757, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 114 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4830, 929, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </aside>
           

        </div>
    </div>
</section>

<<div class=""row"" >
    <div class=""col-md-12"">
        <h1 class=""text-center title"">Core Features</h1>
        <div class=""separator""></div>
        <p class=""text-center""></p>
        <div class=""row grid-space-20"">
            <div class=""col-sm-6"">
                <div class=""box-style-3 right object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""0"">
                    <div class=""icon-container default-bg"">
                        <i class=""fa fa-code""></i>
                    </div>
                    <div class=""body"">
                        <h2>Code2night Tutorials</h2>
                        <p>Code2night Tutorials page contains references to programming solutions</p>
");
            EndContext();
            BeginContext(5857, 560, true);
            WriteLiteral(@"                 </div>
                </div>
                <div class=""box-style-3 right object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""200"">
                    <div class=""icon-container default-bg"">
                        <i class=""fa fa-check""></i>
                    </div>
                    <div class=""body"">
                        <h2>Technologies We Provide's</h2>
                        <p>ASP .NET CORE ,JQUERY, ANGLURJS , ASP.NET MVC , ADO.NET, SQL SERVER</p> 
");
            EndContext();
            BeginContext(6515, 515, true);
            WriteLiteral(@"                  </div>
                </div>
                <div class=""box-style-3 right object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""400"">
                    <div class=""icon-container default-bg"">
                        <i class=""fa fa-book""></i>
                    </div>
                    <div class=""body"">
                        <h2>Blog</h2>
                        <p>Welcome to the Blog section of Code2night...</p>
");
            EndContext();
            BeginContext(7128, 556, true);
            WriteLiteral(@"            </div>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""box-style-3 object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""0"">
                    <div class=""icon-container default-bg"">
                        <i class=""fa fa-leaf""></i>
                    </div>
                    <div class=""body"">
                        <h2>Tutorials</h2>
                        <p>Learn C# ,SQL, Angularjs , Asp.net ...</p>
");
            EndContext();
            BeginContext(7782, 524, true);
            WriteLiteral(@"          </div>
                </div>
                <div class=""box-style-3 object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""200"">
                    <div class=""icon-container default-bg"">
                        <i class=""fa fa-lightbulb-o""></i>
                    </div>
                    <div class=""body"">
                        <h2>Forum</h2>
                        <p>C# Forum, C# Forums, Forums, ASP.NET Forum, VB.NET, WPF ...</p>
");
            EndContext();
            BeginContext(8404, 487, true);
            WriteLiteral(@"         </div>
                </div>
                <div class=""box-style-3 object-non-visible animated object-visible fadeInUpSmall"" data-animation-effect=""fadeInUpSmall"" data-effect-delay=""400"">
                    <div class=""icon-container default-bg"">
                        <i class=""fa fa-code""></i>
                    </div>
                    <div class=""body"">
                        <h2>Latest Technologies</h2>
                        <p>C# ,Asp.Net core</p>
");
            EndContext();
            BeginContext(8989, 1051, true);
            WriteLiteral(@"      </div>
                </div>
            </div>
        </div>
    </div>
</div>

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
                            <footer style=""color:white;font-size:20px;""><cite title=""Source Title"">3 Idiots </cite></footer>
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
");
            WriteLiteral("        <div class=\"row\">\r\n");
            EndContext();
            BeginContext(11572, 60, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- section end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Code2Night.DAL.Common.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
