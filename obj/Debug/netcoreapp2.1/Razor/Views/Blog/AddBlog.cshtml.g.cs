#pragma checksum "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee37ea685451b02a2a3e22b3ee60ca43bc96563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_AddBlog), @"mvc.1.0.view", @"/Views/Blog/AddBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/AddBlog.cshtml", typeof(AspNetCore.Views_Blog_AddBlog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee37ea685451b02a2a3e22b3ee60ca43bc96563", @"/Views/Blog/AddBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_AddBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("OnAddBlogSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("return Validate()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmBlog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
  
    ViewBag.Title = "Add Blog | Code2Night.com";
    ViewBag.MetaDescription = "Welcome To Code2night, write your own blog and reach to the whole world.";
    ViewBag.MetaKeywords = "Add Blog,Code2Night,New Blogs,Code,Programming,Tutorials";
    ViewBag.Canonical = "https://www.code2night.com/Blog/AddBlog";
    Layout = "~/Views/Shared/_Layout.cshtml";

    ViewBag.OpenGraphUrl = "https://www.code2night.com/Blog/AddBlog";
    ViewBag.OpenGraphDescription = "Welcome To Code2night, check out lur latest programming blogs with detailed description to help you out";
    ViewBag.OpenGraphTitle = "Add Blog | Code2Night.com";

#line default
#line hidden
            BeginContext(677, 1583, true);
            WriteLiteral(@"<style>
    .btn-default {
        background-color: white !important;
        color: black !important;
        border-color: black !important;
    }

        .btn-default:hover, .btn-default:focus, .btn-default:active, .btn-default.active, .open .dropdown-toggle.btn-default {
            color: #0066ff !important;
            background-color: #cd3c2e;
            border-color: #cd3c2e;
        }

    .note-toolbar {
        position: static !important;
        z-index: 500;
    }

    .btn-default:hover {
        background-color: white !important;
        color: black !important;
        border-color: black !important;
    }
    .tokenfield
    {
        height:auto !important;
    }
    .panel-heading a {
        font-weight: 400;
        padding: 12px 35px 12px 15px;
        display: inline-block;
        width: 100%;
        background-color: transparent;
        color: #ffffff;
        position: relative;
        text-decoration: none;
    }

    .btn.btn-sm {
   ");
            WriteLiteral(@"     padding: 8px;
        font-size: 12px;
        min-width: 55px;
    }

    .btn {
        padding: 4px 2px !important;
    }

    .main h1#Title.page-title, #blogbody #blog p {
        display: inline-block;
        word-break: break-all;
    }
</style>
<script src=""https://cdn.jsdelivr.net/npm/jquery-ajax-unobtrusive@3.2.6/dist/jquery.unobtrusive-ajax.min.js""></script>
<section class=""main-container"">

    <div class=""container"">
        <div class=""row"">

            <!-- main start -->
            <!-- ================ -->
");
            EndContext();
#line 74 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
             if (Model.Id > 0)
            {

#line default
#line hidden
            BeginContext(2307, 226, true);
            WriteLiteral("                <div class=\"main col-md-6\" style=\"word-break:break-all\">\r\n\r\n                    <!-- page-title start -->\r\n                    <!-- ================ -->\r\n\r\n                    <h1 class=\"page-title\" id=\"Title\">");
            EndContext();
            BeginContext(2534, 11, false);
#line 81 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2545, 371, true);
            WriteLiteral(@"</h1>
                    <!-- page-title end -->
                    <!-- blogpost start -->
                    <article class=""clearfix blogpost full"">
                        <div class=""blogpost-body"">
                            <div class=""side"">
                                <div class=""post-info"">
                                    <span class=""day"">");
            EndContext();
            BeginContext(2917, 14, false);
#line 88 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                 Write(Model.Date.Day);

#line default
#line hidden
            EndContext();
            BeginContext(2931, 65, true);
            WriteLiteral("</span>\r\n                                    <span class=\"month\">");
            EndContext();
            BeginContext(2997, 26, false);
#line 89 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                   Write(Model.Date.ToString("MMM"));

#line default
#line hidden
            EndContext();
            BeginContext(3023, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3025, 15, false);
#line 89 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                                               Write(Model.Date.Year);

#line default
#line hidden
            EndContext();
            BeginContext(3040, 408, true);
            WriteLiteral(@"</span>
                                </div>
                                <div id=""affix""><span class=""share"">Share This</span><div id=""share""></div></div>
                            </div>
                            <div class=""blogpost-content"">
                                <header>
                                    <div class=""submitted""><i class=""fa fa-user pr-5""></i> by <a href=""#"">");
            EndContext();
            BeginContext(3450, 196, false);
#line 95 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                                                                      Write(string.IsNullOrEmpty(Convert.ToString(HttpContextAccessor.HttpContext.Session.GetString("UserName"))) ? "Author" : (Convert.ToString(HttpContextAccessor.HttpContext.Session.GetString("UserName"))));

#line default
#line hidden
            EndContext();
            BeginContext(3647, 165, true);
            WriteLiteral("</a></div>\r\n                                </header>\r\n                                <blockquote>\r\n                                    <p id=\"previewIntroduction\">");
            EndContext();
            BeginContext(3813, 22, false);
#line 98 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                           Write(Model.BlogIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(3835, 157, true);
            WriteLiteral("</p>\r\n                                </blockquote>\r\n\r\n                                <div id=\"blogbody\">\r\n                                    <p id=\"blog\">");
            EndContext();
            BeginContext(3993, 24, false);
#line 102 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                            Write(Html.Raw(Model.BlogBody));

#line default
#line hidden
            EndContext();
            BeginContext(4017, 375, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <footer class=""clearfix"">
                                <ul class=""links pull-left"">

                                    <li><i class=""fa fa-tags pr-5""></i> <a href=""#"" id=""mytags"" class=""text-capitalize""></a><a href=""#"" id=""demotags"" class=""text-capitalize"">");
            EndContext();
            BeginContext(4394, 47, false);
#line 108 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                                                                                                                                          Write(Model.Tags!=null?Model.Tags.Replace("-"," "):"");

#line default
#line hidden
            EndContext();
            BeginContext(4442, 179, true);
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                            </footer>\r\n                        </div>\r\n                    </article>\r\n\r\n                </div>\r\n");
            EndContext();
#line 115 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(4669, 624, true);
            WriteLiteral(@"                <div class=""main col-md-6"" style=""word-break:break-all"">

                    <!-- page-title start -->
                    <!-- ================ -->

                    <h1 class=""page-title"" id=""Title"">Blogpost Title (Dummy Blog)</h1>
                    <!-- page-title end -->
                    <!-- blogpost start -->
                    <article class=""clearfix blogpost full"">
                        <div class=""blogpost-body"">
                            <div class=""side"">
                                <div class=""post-info"">
                                    <span class=""day"">");
            EndContext();
            BeginContext(5294, 16, false);
#line 130 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                 Write(DateTime.Now.Day);

#line default
#line hidden
            EndContext();
            BeginContext(5310, 65, true);
            WriteLiteral("</span>\r\n                                    <span class=\"month\">");
            EndContext();
            BeginContext(5376, 28, false);
#line 131 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                   Write(DateTime.Now.ToString("MMM"));

#line default
#line hidden
            EndContext();
            BeginContext(5404, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5406, 17, false);
#line 131 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                                                 Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(5423, 408, true);
            WriteLiteral(@"</span>
                                </div>
                                <div id=""affix""><span class=""share"">Share This</span><div id=""share""></div></div>
                            </div>
                            <div class=""blogpost-content"">
                                <header>
                                    <div class=""submitted""><i class=""fa fa-user pr-5""></i> by <a href=""#"">");
            EndContext();
            BeginContext(5833, 198, false);
#line 137 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                                                                      Write(string.IsNullOrEmpty((Convert.ToString(HttpContextAccessor.HttpContext.Session.GetString("UserName")))) ? "Author" : (Convert.ToString(HttpContextAccessor.HttpContext.Session.GetString("UserName"))));

#line default
#line hidden
            EndContext();
            BeginContext(6032, 2449, true);
            WriteLiteral(@"</a></div>
                                </header>
                                <blockquote>
                                    <p id=""previewIntroduction"">Please Enter a suitable description for your blog . It must be max 500 characters and must define what is your blog for..</p>
                                </blockquote>
                                <div id=""demoblog"">

                                    <p>
                                        The journal (the truncation of the language `` weblog '') is a speech or informational site printed on the Web consisting of separate, often intimate diary-style book entries (posts ) . Posts are typically exhibited in reverse chronological order, so that the most new place seems Firstly, in the top of the page. Until 2009, blogs were normally the study of a single person, occasionally of a small group, and frequently covered a single person or issue. At this 2010s, `` multi-author blogs '' (MABs) have produced, with posts published by huge am");
            WriteLiteral(@"ounts of writers and sometimes professionally edited. MABs from newspapers, different media outlets, universities, think tanks, support groups, and related institutions responsible for the increasing amount of blog communication.
                                    </p><p>
                                        This growth of Twitter and other `` microblogging '' organizations helps incorporate MABs and single-author blogs into this broadcast media. Journal can also be used as a verb, meaning to keep or bring knowledge to the blog.
                                    </p>

                                </div>
                                <div id=""blogbody"" style=""display:none"">
                                    <p id=""blog""></p>
                                </div>
                            </div>
                            <footer class=""clearfix"">
                                <ul class=""links pull-left"">
                                    <li><i class=""fa fa-comment-o pr-5""></i>");
            WriteLiteral(@" <a href=""#"">22 comments</a> |</li>
                                    <li><i class=""fa fa-tags pr-5""></i> <a href=""#"" id=""mytags"" class=""text-capitalize""></a><a href=""#"" id=""demotags"" class=""text-capitalize"">tags1, tag2</a></li>
                                </ul>
                            </footer>
                        </div>
                    </article>

                </div>
");
            EndContext();
#line 165 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
            }

#line default
#line hidden
            BeginContext(8496, 180, true);
            WriteLiteral("            <!-- main end -->\r\n            <!-- sidebar start -->\r\n            <aside class=\"col-md-5 col-md-offset-1\">\r\n                <div class=\"sidebar\">\r\n                    ");
            EndContext();
            BeginContext(8676, 4306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee37ea685451b02a2a3e22b3ee60ca43bc9656320604", async() => {
                BeginContext(8894, 445, true);
                WriteLiteral(@"
                        <div class=""block clearfix"">
                            <h3 class=""title"">Write New Blog</h3>
                            <div class=""separator""></div>
                            <nav>
                                <ul class=""nav nav-pills nav-stacked"">
                                    <li>
                                        <label for=""title"">Title</label>
                                        ");
                EndContext();
                BeginContext(9340, 25, false);
#line 178 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
                EndContext();
                BeginContext(9365, 111, true);
                WriteLiteral("\r\n                                        <input type=\"text\" class=\"form-control\" onkeydown=\"ChangeTitle(this)\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 9476, "\"", 9496, 1);
#line 179 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
WriteAttributeValue("", 9484, Model.Title, 9484, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9497, 197, true);
                WriteLiteral(" name=\"Title\" onkeyup=\"ChangeTitle(this)\" id=\"title\" />\r\n                                        <label for=\"title\">About Blog (max 500 characters)</label>\r\n                                        ");
                EndContext();
                BeginContext(9695, 135, false);
#line 181 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                   Write(Html.TextAreaFor(x => x.BlogIntroduction, new { @onkeydown = "ChangeIntroduction(this)", @class = "form-control", @maxlength = "500" }));

#line default
#line hidden
                EndContext();
                BeginContext(9830, 172, true);
                WriteLiteral("\r\n\r\n                                        <label for=\"blogbody\">Article</label><div class=\"example\">\r\n                                            <div class=\"summernote\">");
                EndContext();
                BeginContext(10003, 24, false);
#line 184 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                               Write(Html.Raw(Model.BlogBody));

#line default
#line hidden
                EndContext();
                BeginContext(10027, 132, true);
                WriteLiteral("</div>\r\n                                        </div>\r\n                                        <input type=\"hidden\" name=\"BlogBody\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 10159, "\"", 10182, 1);
#line 186 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
WriteAttributeValue("", 10167, Model.BlogBody, 10167, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10183, 323, true);
                WriteLiteral(@" id=""BlogBody"" />
                                    </li>
                                    <li>
                                        <label for=""tokenfield"">Categories</label>
                                        <input type=""text"" class=""form-control"" id=""tokenfield"" name=""Tags"" onchange=""ChangeTags(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 10506, "\'", 10527, 1);
#line 190 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
WriteAttributeValue("", 10514, Model.Tags, 10514, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10528, 292, true);
                WriteLiteral(@" placeholder=""Type Tags and hit enter"" />
                                    </li>
                                    <li>
                                        <label for=""title"">Video Embed Link</label>
                                        <input type=""text"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 10820, "\"", 10845, 1);
#line 194 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
WriteAttributeValue("", 10828, Model.VideoEmbed, 10828, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10846, 371, true);
                WriteLiteral(@" name=""VideoEmbed"" id=""videoembed"" />
                                    </li>
                                    <li>
                                    <li>
                                        <label for=""title"">Upload Documents</label>
                                        <input type=""file"" name=""documents"" />
                                        ");
                EndContext();
                BeginContext(11218, 31, false);
#line 200 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                   Write(Html.HiddenFor(x => x.Document));

#line default
#line hidden
                EndContext();
                BeginContext(11249, 533, true);
                WriteLiteral(@"
                                    </li>
                                    <li style=""margin-top:10px;height:100px"">
                                        <label for=""Visibility"">Visibility</label>
                                        <div class=""col-md-12 col-sm-12"">
                                            <div class=""radio"" style=""float:left"">
                                                <label for=""Visibility2"" >
                                                    <input type=""radio"" name=""Visibility"" ");
                EndContext();
                BeginContext(11784, 28, false);
#line 207 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                                                      Write(Model.IsPrivate?"checked":"");

#line default
#line hidden
                EndContext();
                BeginContext(11813, 496, true);
                WriteLiteral(@" id=""Visibility2"" value=""Private"">
                                                    Private
                                                </label>
                                            </div>
                                            <div class=""radio"" style="" float: left; margin-top: 9px; margin-left: 10px; "">
                                                <label for=""Visibility1"">
                                                    <input type=""radio"" name=""Visibility"" ");
                EndContext();
                BeginContext(12311, 29, false);
#line 213 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                                                                      Write(!Model.IsPrivate?"checked":"");

#line default
#line hidden
                EndContext();
                BeginContext(12341, 634, true);
                WriteLiteral(@" id=""Visibility1"" value=""Public"">
                                                    Public
                                                </label>
                                            </div>
                                        </div>
                                    </li>
                                    <li>
                                        <button id=""submit"" value=""Submit Blog"" class=""btn btn-success"">Submit Blog</button>
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    ");
                EndContext();
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12982, 5539, true);
            WriteLiteral(@"
                       
                </div>
            </aside>
        </div>
    </div>
</section>

<script src=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js""></script>

<script>
    var Validate = function () {
        if ($('#title').val() == """") {
            alert(""Title cannot be blank !"");
            return false;
        }
        if ($('#BlogBody').val() == """") {
            alert(""Blog Body cannot be blank !"");
            return false;
        }
        if ($('#BlogIntroduction').val() == """") {
            alert(""Blog Introduction cannot be blank !"");
            return false;
        }
        ShowLoader();
    }
    $(document).ready(function () {
       window.addEventListener(""submit"", function (e) {
           var form = e.target;
           e.preventDefault();
           var valid = true;
           if ($('#title').val() == """") {
              // alert(""Title cannot be blank !"");
               valid = false;
               re");
            WriteLiteral(@"turn false;
           }
           if ($('#BlogBody').val() == """") {
               //alert(""Blog Body cannot be blank !"");
               valid = false;
               return false;
           }
           if ($('#BlogIntroduction').val() == """") {
              // alert(""Blog Introduction cannot be blank !"");
               valid = false;
               return false;
           }
           if (valid) {
               ShowLoader();
               if (form.getAttribute(""enctype"") === ""multipart/form-data"") {
                   if (form.dataset.ajax) {
                       e.preventDefault();
                       e.stopImmediatePropagation();
                       var xhr = new XMLHttpRequest();
                       xhr.open(form.method, form.action);
                       xhr.onreadystatechange = function (data) {
                           HideLoader();
                           if (xhr.readyState == 4 && xhr.status == 200) {
                               var response = JSON");
            WriteLiteral(@".parse(xhr.responseText);

                               Swal.fire({
                                   position: 'top-end',
                                   type: 'success',
                                   title: ""Blog Submitted Successfully"",
                                   showConfirmButton: false,
                                   timer: 3000
                               });
                               setTimeout(
                                   function () {
                                       window.location.href = ""/Blog/AddBlog"";
                                   }
                                   , 3000);
                           }
                           else {
                               console.log(data);
                           }
                       }
                   };
                   xhr.send(new FormData(form));
               }
           }

        }, true);

       $("".summernote"").summernote({
           callbacks: {
 ");
            WriteLiteral(@"              onChange: function (contents, $editable) {
                   console.log('onChange:', contents, $editable);
                   if (contents == """") {
                       $(""#blog"").hide();
                       $(""#demoblog"").show();

                   }
                   else {
                       $(""#blog"").html(contents);
                       $('#BlogBody').val(contents);
                       $(""#blog"").show();
                       $(""#blogbody"").show();
                       $(""#demoblog"").hide();
                   }

               },

               onImageUpload: function (files) {
                   for (let i = 0; i < files.length; i++) {
                       UploadImage(files[i]);
                   }
               }

           }
       });



   });
   var ChangeTags = function (ctrl) {
       console.log($(ctrl).val());
       if ($(ctrl).val() == """") {
           $(""#mytags"").hide();
           $(""#demotags"").show();
       }
 ");
            WriteLiteral(@"      else {
           $(""#mytags"").html($(ctrl).val());
           $(""#mytags"").show();
           $(""#demotags"").hide();
       }
   }
   var ChangeIntroduction=function(ctrl)
   {
       if ($(ctrl).val() == """")
       {
           $(""#previewIntroduction"").html('Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.');
       }
       else
       {
           $(""#previewIntroduction"").html($(ctrl).val());
       }

    }
    var ChangeTitle = function (ctrl) {
        if ($(ctrl).val() == """") {
            $(""#Title"").html('BlogPost Title (Dummy Blog)');
        }
        else {
            $(""#Title"").html($(ctrl).val());
        }
    }
    $('#tokenfield').tokenfield({
        autocomplete: {

            source: [],
            delay: 100
        },
        showAutocompleteOnFocus: true
    })
    var OnAddBlogSuccess = function (reponse) {
        if (response.data == 0) ");
            WriteLiteral(@"{
            }
            else {
                Swal.fire({
                    position: 'top-end',
                    type: 'success',
                    title: ""Blog Submitted Successfully"",
                    showConfirmButton: false,
                    timer: 3000
                });
                setTimeout(
                    function () {
                        window.location.href = '");
            EndContext();
            BeginContext(18522, 28, false);
#line 392 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
                                           Write(Url.Action("AddBlog","Blog"));

#line default
#line hidden
            EndContext();
            BeginContext(18550, 133, true);
            WriteLiteral("\';\r\n                    }\r\n                , 3000);\r\n\r\n            }\r\n    }\r\n\r\n     function UploadImage(file) {\r\n        var url = \'");
            EndContext();
            BeginContext(18684, 32, false);
#line 400 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\AddBlog.cshtml"
              Write(Url.Action("UploadFile", "Blog"));

#line default
#line hidden
            EndContext();
            BeginContext(18716, 675, true);
            WriteLiteral(@"';

        formData = new FormData();
        formData.append(""aUploadedFile"", file);
        $.ajax({
            type: 'POST',
            url: url,
            data: formData,
            cache: false,
            contentType: false,
            processData: false,
            success: function (FileUrl) {
               // alert(FileUrl);
                var imgNode = document.createElement('img');
                imgNode.src = FileUrl;
                $('.summernote').summernote('insertNode', imgNode);
            },
            error: function (data) {
                alert(data.responseText);
            }
        });
    }

</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.DAL.Common.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
