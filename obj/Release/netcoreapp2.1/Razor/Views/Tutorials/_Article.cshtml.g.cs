#pragma checksum "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Tutorials\_Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f46352b56fbf0248c4f7dab4f2769bc8289f7f12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tutorials__Article), @"mvc.1.0.view", @"/Views/Tutorials/_Article.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tutorials/_Article.cshtml", typeof(AspNetCore.Views_Tutorials__Article))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f46352b56fbf0248c4f7dab4f2769bc8289f7f12", @"/Views/Tutorials/_Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Tutorials__Article : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 23, true);
            WriteLiteral("<h1 class=\"page-title\">");
            EndContext();
            BeginContext(62, 18, false);
#line 2 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Tutorials\_Article.cshtml"
                  Write(Model.articletitle);

#line default
#line hidden
            EndContext();
            BeginContext(80, 44, true);
            WriteLiteral("</h1>\r\n<hr>\r\n<!-- page-title end -->\r\n\r\n<p> ");
            EndContext();
            BeginContext(125, 27, false);
#line 6 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Tutorials\_Article.cshtml"
Write(Html.Raw(Model.ArticleBody));

#line default
#line hidden
            EndContext();
            BeginContext(152, 5, true);
            WriteLiteral("</p> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.DAL.Common.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
