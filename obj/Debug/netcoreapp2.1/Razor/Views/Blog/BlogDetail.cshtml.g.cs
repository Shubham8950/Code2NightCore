#pragma checksum "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b98f995c378514a5554656d82cd4d4b977875cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetail), @"mvc.1.0.view", @"/Views/Blog/BlogDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogDetail.cshtml", typeof(AspNetCore.Views_Blog_BlogDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b98f995c378514a5554656d82cd4d4b977875cd", @"/Views/Blog/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.MyBlogs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("download", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("itemprop", new global::Microsoft.AspNetCore.Html.HtmlString("url"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<string> List = new List<string>();
    foreach (var item in Model.BlogsList.Where(x => x.Tags != null).Select(x => x.Tags.Split(',')).ToList())
    {

        foreach (var tag in item)
        {
            List.Add(tag.Trim());
        }

    }
    ViewBag.Title = Model.MyBlog.Title + " | Code2night.com";
    ViewBag.MetaDescription = Model.MyBlog.BlogIntroduction;
    ViewBag.MetaKeywords = "Code2Night,Code,Programming,Tutorials," + string.Join(",", List);
    ViewBag.Canonical = "https://www.code2night.com/Blog/MyBlog/" + Model.MyBlog.BlogUrl;

    ViewBag.OpenGraphUrl = "https://www.code2night.com/Blog/MyBlog/" + Model.MyBlog.BlogUrl;
    ViewBag.OpenGraphDescription = Model.MyBlog.BlogIntroduction;
    ViewBag.OpenGraphTitle = Model.MyBlog.Title;



#line default
#line hidden
            BeginContext(885, 262, true);
            WriteLiteral(@"<script data-ad-client=""ca-pub-2622840091485569"" async src=""https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js""></script>
<script id=""dsq-count-scr"" src=""//codetonight.disqus.com/count.js""></script>
<script type=""application/ld+json"">
    {
    """);
            EndContext();
            BeginContext(1148, 39, true);
            WriteLiteral("@context\" : \"http://schema.org\",\r\n    \"");
            EndContext();
            BeginContext(1188, 35, true);
            WriteLiteral("@type\" : \"Article\",\r\n    \"name\" : \"");
            EndContext();
            BeginContext(1224, 18, false);
#line 31 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
         Write(Model.MyBlog.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1242, 22, true);
            WriteLiteral("\",\r\n    \"headline\" : \"");
            EndContext();
            BeginContext(1265, 18, false);
#line 32 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
             Write(Model.MyBlog.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1283, 56, true);
            WriteLiteral("\",\r\n    \"url\" : \"https://www.code2night.com/Blog/MyBlog/");
            EndContext();
            BeginContext(1341, 21, false);
#line 33 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                                Write(@Model.MyBlog.BlogUrl);

#line default
#line hidden
            EndContext();
            BeginContext(1363, 27, true);
            WriteLiteral("\",\r\n    \"author\" : {\r\n    \"");
            EndContext();
            BeginContext(1391, 34, true);
            WriteLiteral("@type\" : \"Person\",\r\n    \"name\" : \"");
            EndContext();
            BeginContext(1426, 23, false);
#line 36 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
         Write(Model.MyBlog.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 34, true);
            WriteLiteral("\"\r\n    },\r\n    \"datePublished\" : \"");
            EndContext();
            BeginContext(1484, 40, false);
#line 38 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                  Write(Model.MyBlog.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 28, true);
            WriteLiteral("\",\r\n    \"articleSection\" : \"");
            EndContext();
            BeginContext(1553, 29, false);
#line 39 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                   Write(Model.MyBlog.BlogIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(1582, 25, true);
            WriteLiteral("\",\r\n    \"articleBody\" : \"");
            EndContext();
            BeginContext(1608, 29, false);
#line 40 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                Write(Model.MyBlog.BlogIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 30, true);
            WriteLiteral("\",\r\n    \"publisher\" : {\r\n    \"");
            EndContext();
            BeginContext(1668, 1399, true);
            WriteLiteral(@"@type"" : ""Organization"",
    ""name"" : ""Code2night""
    }
    }
</script>

<style>
    pre {
        padding: 10px 16px;
        border-radius: 2px;
    }

        pre p {
            display: block;
            line-height: 1.5rem;
            counter-increment: line;
        }

            pre p:before {
                content: counter(line);
                display: inline-block;
                border-right: 1px solid #ddd;
                padding: 0 .5em;
                margin-right: .5em;
                color: #888
            }

    #disqus_thread {
        overflow: hidden;
    }

    iframe {
        margin-bottom: -54px;
    }
</style>


<div class=""page-intro"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ol class=""breadcrumb"">
                    <li><i class=""fa fa-home pr-10""></i><a href=""index.html"">Home</a></li>
                    <li class=""active"">Blogpost</li>
                </ol>
");
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- page-intro end -->
<!-- main-container start -->
<!-- ================ -->
<section class=""main-container"">
    <div class=""container"">
        <div class=""row"">
            <div class=""main col-md-8"" itemscope itemtype=""http://schema.org/Blog"">

                <h1 class=""page-title"" itemprop=""headline"">");
            EndContext();
            BeginContext(3068, 18, false);
#line 99 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                                      Write(Model.MyBlog.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3086, 288, true);
            WriteLiteral(@"</h1>
                <article class=""clearfix blogpost full"">

                    <div class=""blogpost-body"">
                        <div class=""side"">
                            <div class=""post-info"" itemprop=""datePublished"">
                                <span class=""day"">");
            EndContext();
            BeginContext(3375, 32, false);
#line 105 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                             Write(Model.MyBlog.Date.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(3407, 61, true);
            WriteLiteral("</span>\r\n                                <span class=\"month\">");
            EndContext();
            BeginContext(3469, 33, false);
#line 106 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                               Write(Model.MyBlog.Date.ToString("MMM"));

#line default
#line hidden
            EndContext();
            BeginContext(3502, 6, true);
            WriteLiteral("<br />");
            EndContext();
            BeginContext(3509, 34, false);
#line 106 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                                                                       Write(Model.MyBlog.Date.ToString("yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3543, 406, true);
            WriteLiteral(@"</span>
                            </div>
                            <div id=""affix"">
                                <span class=""share"">Share This</span><div id=""share"">
                                    <div id=""share"" class=""sharrre"">
                                        <ul class=""social-links clearfix"">
                                            <li class=""facebook""><a itemprop=""url""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3949, "\"", 4051, 2);
            WriteAttributeValue("", 3956, "http://www.facebook.com/sharer.php?u=https://code2night.com/Blog/MyBlog/", 3956, 72, true);
#line 112 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 4028, Model.MyBlog.BlogUrl, 4028, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4052, 139, true);
            WriteLiteral(" target=\"_blank\"><i class=\"fa fa-facebook\"></i></a></li>\r\n                                            <li class=\"twitter\"><a itemprop=\"url\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4191, "\"", 4327, 5);
            WriteAttributeValue("", 4198, "http://twitter.com/share?url=https://code2night.com/Blog/MyBlog/", 4198, 64, true);
#line 113 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 4262, Model.MyBlog.BlogUrl, 4262, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 4285, "&text=", 4285, 6, true);
#line 113 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 4291, Model.MyBlog.Title, 4291, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4312, "&via=code2night", 4312, 15, true);
            EndWriteAttribute();
            BeginContext(4328, 138, true);
            WriteLiteral(" target=\"_blank\"><i class=\"fa fa-twitter\"></i></a></li>\r\n                                            <li class=\"twitter\"><a itemprop=\"url\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4466, "\"", 4588, 4);
            WriteAttributeValue("", 4473, "http://reddit.com/submit?url=https://code2night.com/Blog/MyBlog/", 4473, 64, true);
#line 114 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 4537, Model.MyBlog.BlogUrl, 4537, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 4560, "&title=", 4560, 7, true);
#line 114 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 4567, Model.MyBlog.Title, 4567, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4589, 143, true);
            WriteLiteral(" target=\"_blank\"><i class=\"fa fa-reddit-alien\"></i></a></li>\r\n                                            <li class=\"twitter\"><a itemprop=\"url\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4732, "\"", 4834, 2);
            WriteAttributeValue("", 4739, "http://www.tumblr.com/share/link?url=https://code2night.com/Blog/MyBlog/", 4739, 72, true);
#line 115 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 4811, Model.MyBlog.BlogUrl, 4811, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4835, 137, true);
            WriteLiteral(" target=\"_blank\"><i class=\"fa fa-tumblr\"></i></a></li>\r\n                                            <li class=\"twitter\"><a itemprop=\"url\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4972, "\"", 5105, 3);
            WriteAttributeValue("", 4979, "http://www.linkedin.com/shareArticle?mini=true&url=https://code2night.com/Blog/MyBlog/", 4979, 86, true);
#line 116 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 5065, Model.MyBlog.BlogUrl, 5065, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 5088, "&title=Code2Night", 5088, 17, true);
            EndWriteAttribute();
            BeginContext(5106, 529, true);
            WriteLiteral(@" target=""_blank""><i class=""fa fa-linkedin""></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""blogpost-content"" style=""word-break:break-word"">
                            <header>
                                <div class=""submitted"">
                                    <i class=""fa fa-user pr-5""></i> by <a itemprop=""author""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5635, "\"", 5702, 4);
            WriteAttributeValue("", 5642, "/Blog/Author/", 5642, 13, true);
#line 125 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 5655, Model.MyBlog.AuthorId, 5655, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 5677, "-", 5677, 1, true);
#line 125 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 5678, Model.MyBlog.AuthorName, 5678, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5703, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5705, 23, false);
#line 125 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                                                                                                                                           Write(Model.MyBlog.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(5728, 205, true);
            WriteLiteral("</a>\r\n                                    <a style=\"\r\n    color: black;\r\n    margin-left: 16px;\r\n\"><i class=\"fa fa-eye\"></i><p itemprop=\"interactionCount\" style=\" display: inline-block; margin-left: 6px;\">");
            EndContext();
            BeginContext(5934, 22, false);
#line 129 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                                                                                       Write(Model.MyBlog.TotalView);

#line default
#line hidden
            EndContext();
            BeginContext(5956, 10, true);
            WriteLiteral("</p></a>\r\n");
            EndContext();
#line 130 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
 if (!string.IsNullOrEmpty(Model.MyBlog.Document))
{

#line default
#line hidden
            BeginContext(6021, 65, true);
            WriteLiteral("    <i class=\"fa fa-download pr-5\" style=\"margin-left:10px\"></i> ");
            EndContext();
            BeginContext(6086, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b98f995c378514a5554656d82cd4d4b977875cd19271", async() => {
                BeginContext(6150, 21, true);
                WriteLiteral(" Download Attachments");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6107, "~/Uploads/BlogDocs/", 6107, 19, true);
#line 132 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
AddHtmlAttributeValue("", 6126, Model.MyBlog.Document, 6126, 22, false);

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
            BeginContext(6175, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 133 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
}

#line default
#line hidden
            BeginContext(6180, 19, true);
            WriteLiteral("</div>\r\n</header>\r\n");
            EndContext();
#line 136 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
 if (Model.MyBlog.VideoEmbed != null)
{

#line default
#line hidden
            BeginContext(6241, 67, true);
            WriteLiteral("    <div class=\"embed-responsive embed-responsive-16by9\">\r\n        ");
            EndContext();
            BeginContext(6309, 33, false);
#line 139 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
   Write(Html.Raw(Model.MyBlog.VideoEmbed));

#line default
#line hidden
            EndContext();
            BeginContext(6342, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 141 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
}

#line default
#line hidden
            BeginContext(6359, 47, true);
            WriteLiteral("<div>\r\n    <p itemprop=\"articleBody\">\r\n        ");
            EndContext();
            BeginContext(6407, 31, false);
#line 144 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
   Write(Html.Raw(Model.MyBlog.BlogBody));

#line default
#line hidden
            EndContext();
            BeginContext(6438, 174, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n</div>\r\n</div>\r\n\r\n<footer class=\"clearfix\" style=\"margin-bottom:10px\">\r\n    <ul class=\"links pull-left\">\r\n        <li><i class=\"fa fa-comment-o pr-5\"></i>");
            EndContext();
            BeginContext(6612, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b98f995c378514a5554656d82cd4d4b977875cd22825", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6621, "~/Blog/MyBlog/", 6621, 14, true);
#line 152 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
AddHtmlAttributeValue("", 6635, Model.MyBlog.BlogUrl, 6635, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 6656, "#disqus_thread", 6656, 14, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6676, 88, true);
            WriteLiteral(" |</li>\r\n        <li itemprop=\"keywords\">\r\n            <i class=\"fa fa-tags pr-5\"></i>\r\n");
            EndContext();
#line 155 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
             if (Model.MyBlog.Tags != null)
            {
                foreach (var str in Model.MyBlog.Tags.Split(',').ToList())
                {

#line default
#line hidden
            BeginContext(6919, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(6939, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b98f995c378514a5554656d82cd4d4b977875cd24991", async() => {
                BeginContext(6982, 21, false);
#line 159 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                                         Write(str.Replace("-", " "));

#line default
#line hidden
                EndContext();
                BeginContext(7003, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(7006, 117, false);
#line 159 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                                                                 Write(Model.MyBlog.Tags.Split(',').ToList().IndexOf(str).Equals(Model.MyBlog.Tags.Split(',').ToList().Count - 1) ? "" : ",");

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6963, "~/Blog/Tags/", 6963, 12, true);
#line 159 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
AddHtmlAttributeValue("", 6975, str, 6975, 4, false);

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
            BeginContext(7128, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 160 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(7164, 836, true);
            WriteLiteral(@"        </li>
    </ul>
</footer>

</article>

<div id=""mycmnt"">
    <h2 class=""title"">Comments</h2><div id=""disqus_thread""></div>
    <script>

        (function () { // DON'T EDIT BELOW THIS LINE
            var d = document, s = d.createElement('script');
            s.src = 'https://codetonight.disqus.com/embed.js';
            s.setAttribute('data-timestamp', +new Date());
            (d.head || d.body).appendChild(s);
        })();
    </script>
    <noscript> <a href=""https://disqus.com/?ref_noscript""></a></noscript>
</div>
</div>
<!-- main end -->
<!-- sidebar start -->
<aside class=""col-md-3 col-md-offset-1"">
    <div class=""sidebar"">
        <div class=""block clearfix"">
            <h3 class=""title"">Tags</h3>
            <div class=""separator""></div>
            <div class=""tags-cloud"">
");
            EndContext();
#line 190 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                 foreach (var str in List.Distinct().ToList())
                {

#line default
#line hidden
            BeginContext(8083, 83, true);
            WriteLiteral("                    <div class=\"tag\" itemprop=\"keywords\">\r\n                        ");
            EndContext();
            BeginContext(8166, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b98f995c378514a5554656d82cd4d4b977875cd28953", async() => {
                BeginContext(8194, 21, false);
#line 193 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                                              Write(str.Replace("-", " "));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8175, "~/Blog/Tags/", 8175, 12, true);
#line 193 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
AddHtmlAttributeValue("", 8187, str, 8187, 4, false);

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
            BeginContext(8219, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 195 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Blog\BlogDetail.cshtml"
                }

#line default
#line hidden
            BeginContext(8268, 1903, true);
            WriteLiteral(@"            </div>
            <div>
                <script async src=""https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js""></script>
                <!-- DETAIL -->
                <ins class=""adsbygoogle""
                     style=""display:block""
                     data-ad-client=""ca-pub-2622840091485569""
                     data-ad-slot=""3445995263""
                     data-ad-format=""auto""
                     data-full-width-responsive=""true""></ins>
                <script>
                    (adsbygoogle = window.adsbygoogle || []).push({});
                </script>
            </div>
        </div>
    </div>
</aside>
</div>
</div>

<script id=""dsq-count-scr"" src=""//codetonight.disqus.com/count.js"" async></script>
<script>

    //function wrapNode(node) {
    //    $(node).replaceWith(""<p>"" + node.textContent + ""</p>"");
    //}
    //document.addEventListener('DOMContentLoaded', (event) => {

    //    $('pre').each(function (index, elem) {
    //        ");
            WriteLiteral(@"var d = $(this)[0];
    //        for (var i = 0; i < d.childNodes.length; i++) {
    //            if (d.childNodes[i].nodeType === 3 &&
    //                d.childNodes[i].textContent.replace(/^\s+|\s+$/g, """")) {
    //                wrapNode(d.childNodes[i]);
    //            }
    //        }

    //       // var lines = $(this).text().split('\n');
    //       // var paras = '';
    //       // $.each(lines, function (i, line) {
    //       //     // $(line).wrap('<p></p>');
    //       //     if (line && line.indexOf('<input')==-1) {
    //       //         paras += '<p>' + line + '</p>';
    //       //     }
    //       // });
    //       // paras.replace(/[\r\n]+/g, '\n');
    //       //// $(this).html('');
    //       //// $(this).append(paras);
    //       //$(this).html(paras);
    //    });
    //});
</script>
</section>");
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
