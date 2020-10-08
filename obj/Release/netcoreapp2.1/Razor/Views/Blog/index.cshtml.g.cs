#pragma checksum "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10e6bb5f811caba30e221226843a60c050d8e60f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_index), @"mvc.1.0.view", @"/Views/Blog/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/index.cshtml", typeof(AspNetCore.Views_Blog_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e6bb5f811caba30e221226843a60c050d8e60f", @"/Views/Blog/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.MyBlogs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BlogsList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\index.cshtml"
  
    ViewBag.Title = "Blogs | Code2Night.com";
    ViewBag.MetaDescription = "Welcome To Code2night, check out lur latest programming blogs with detailed description to help you out";
    ViewBag.MetaKeywords = "Code2Night,Blogs,Stripe,Slick,MVC,Exception Handling,Code,Programming,Tutotials,Slick Slider,IIS,Internet Information Services";
    ViewBag.Canonical = "https://www.code2night.com/Blog/index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.OpenGraphUrl = "https://www.code2night.com/Blog/index";
    ViewBag.OpenGraphDescription = "Welcome To Code2night, check out lur latest programming blogs with detailed description to help you out";
    ViewBag.OpenGraphTitle = "Blogs | Code2Night.com";

#line default
#line hidden
            BeginContext(769, 218, true);
            WriteLiteral("<div class=\"page-intro\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li><i class=\"fa fa-home pr-10\"></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 987, "\"", 1022, 1);
#line 17 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\index.cshtml"
WriteAttributeValue("", 994, Url.Action("index","Users"), 994, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1023, 55, true);
            WriteLiteral(">Home</a></li>\r\n                    <li class=\"active\">");
            EndContext();
            BeginContext(1079, 13, false);
#line 18 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\index.cshtml"
                                  Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 529, true);
            WriteLiteral(@"</li>
                </ol>
            </div>
        </div>
    </div>
</div>
<section class=""main-container"">
    <div class=""container"" id=""container"">
        <div class=""row"">
            <div class=""main col-md-12"">
                <div class=""row"" style=""margin-bottom: 55px;"">
                    <div class=""col-md-9 col-sm-12 mt-1"">
                        <h1 class=""page-title"">Latest Blogs</h1>  <input type=""hidden"" id=""hdnIsFilter"" />
                        <input type=""hidden"" id=""hdnTotalRecords""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1621, "\"", 1701, 1);
#line 31 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\index.cshtml"
WriteAttributeValue("", 1629, Model.BlogsList.Any()?Model.BlogsList.FirstOrDefault().TotalRecords:0, 1629, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1702, 810, true);
            WriteLiteral(@" />
                        <input type=""hidden"" id=""pagenumber"" value=""1"" />
                        <div class=""separator-2""></div>
                    </div>
                    <div class=""col-md-3 col-sm-12 mt-1 d-flex"" style=""display: flex;margin-top: 20px;max-width: 368px;
"">
                        <div class=""form-group"" style=""width: 93%"">
                            <input type=""text"" id=""txtsearchblog"" class=""form-control"" style=""float:right;position:absolute"" onblur=""SearchBlogs()"" placeholder=""Search"">
                            <i class=""fa fa-search form-control-feedback""></i>
                        </div>
                    </div>
                </div>
                <div>
                    <div id=""blogslist"" class=""masonry-grid row"">
                          ");
            EndContext();
            BeginContext(2512, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10e6bb5f811caba30e221226843a60c050d8e60f7603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 45 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2555, 563, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col-md-12 text-center"" id=""loader"" style=""display:none"">
                        <button class=""buttonload btn btn-primary"">
                            <i class=""fa fa-spinner fa-spin""></i>  Loading
                        </button>
                    </div>
                </div>
                </div>
            </div>
        <div class=""row"" style=""text-align:center""><div class=""container""> <div style=""margin:auto auto"" id=""pagination""></div></div></div>
    </div>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.DAL.Common.MyBlogs> Html { get; private set; }
    }
}
#pragma warning restore 1591
