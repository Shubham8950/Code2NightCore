#pragma checksum "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Shared\_SuccessfulRegistration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a470d9b919841a02d8f3c1a348049ffc1ff54efe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SuccessfulRegistration), @"mvc.1.0.view", @"/Views/Shared/_SuccessfulRegistration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SuccessfulRegistration.cshtml", typeof(AspNetCore.Views_Shared__SuccessfulRegistration))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a470d9b919841a02d8f3c1a348049ffc1ff54efe", @"/Views/Shared/_SuccessfulRegistration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SuccessfulRegistration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 607, true);
            WriteLiteral(@"<div class=""main "" data-animation-effect=""fadeInDownSmall"" data-effect-delay=""300"">
    <div class=""form-block center-block"">
        <h2 class=""title"">Notification</h2>
        <hr>
        <div class=""form-horizontal"" role=""form"" name=""form"">
          
            <div class=""text-center""><h1>SuccessFully Registered</h1><h3>A verfication mail has been sent on your Email with the activation link</h3><h4>Click on the Activation Link to activate your account</h4></div>
            <div class=""form-group"">
                <div class=""text-center"">
                   <a class=""btn btn-default""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 607, "\"", 642, 1);
#line 10 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Shared\_SuccessfulRegistration.cshtml"
WriteAttributeValue("", 614, Url.Action("Login","Users"), 614, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(643, 96, true);
            WriteLiteral(">Login Now</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
