#pragma checksum "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd41425673cafc9c8a1d3aef5639ff04c309068"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_VerifyAccount), @"mvc.1.0.view", @"/Views/Users/VerifyAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/VerifyAccount.cshtml", typeof(AspNetCore.Views_Users_VerifyAccount))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd41425673cafc9c8a1d3aef5639ff04c309068", @"/Views/Users/VerifyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_VerifyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-app", new global::Microsoft.AspNetCore.Html.HtmlString("User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-controller", new global::Microsoft.AspNetCore.Html.HtmlString("UserController"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml"
  
    ViewBag.Title = "Activate Account";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 195, true);
            WriteLiteral("<div class=\"main \" data-animation-effect=\"fadeInDownSmall\" data-effect-delay=\"300\">\r\n    <div class=\"form-block center-block\">\r\n        <h2 class=\"title\">Notification</h2>\r\n        <hr>\r\n        ");
            EndContext();
            BeginContext(292, 1308, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd41425673cafc9c8a1d3aef5639ff04c3090686047", async() => {
                BeginContext(391, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml"
           if (ViewBag.Activated == 0)
          {

#line default
#line hidden
                BeginContext(446, 589, true);
                WriteLiteral(@"            <div class=""text-center""><h1>Account Activation Failed</h1><h4>Your activation link is expired or not accurate.Try to Send Activation Link Again to your Registered Email Account to verify Again</h4></div>
            <div class=""form-group"">
                <div class=""text-center""><input  type=""Email"" ng-model=""Email"" required name=""Email"" /></div>
                <div class=""text-center"">
                    <input type=""submit"" class=""btn btn-default"" value=""Resend Verification Mail"" placeholder=""Registered Email"" ng-click=""SendMail()""/> <a class=""btn btn-default""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1035, "\"", 1070, 1);
#line 17 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml"
WriteAttributeValue("", 1042, Url.Action("Login","Users"), 1042, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1071, 62, true);
                WriteLiteral(">Login Now</a>\r\n                </div>\r\n            </div>  \r\n");
                EndContext();
#line 20 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml"
          }
          else
          {

#line default
#line hidden
                BeginContext(1175, 287, true);
                WriteLiteral(@"            <div class=""text-center""><h1>Account Activated</h1><h3>Your account is successfully activated .</h3><h4>You can Login Now with your account</h4></div>
            <div class=""form-group"">
                <div class=""text-center"">
                <a class=""btn btn-default""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1462, "\"", 1497, 1);
#line 26 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml"
WriteAttributeValue("", 1469, Url.Action("Login","Users"), 1469, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1498, 60, true);
                WriteLiteral(">Login Now</a>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 29 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml"
          }

#line default
#line hidden
                BeginContext(1571, 22, true);
                WriteLiteral("            \r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(1600, 725, true);
            WriteLiteral(@"
    </div>
</div>
<script>
  var app = angular.module('User', [])
        app.controller('UserController', function ($scope, $http, $window) {

            $scope.Email = """";
            $scope.SendMail = function () {

                if ($scope.Email == """") {
                    Swal.fire({
                        position: 'top-center',
                        type: 'info',
                        title: ""Enter your Registered Email!"",
                        showConfirmButton: false,
                        timer: 3000
                    });
                    return false;
                }
                var post = $http({
                    method: ""POST"",
                    url: '");
            EndContext();
            BeginContext(2326, 44, false);
#line 53 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml"
                     Write(Url.Action("ResendVerificationMail", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(2370, 707, true);
            WriteLiteral(@"',
                    dataType: 'json',
                    data: { Email: $scope.Email },
                    headers: { ""Content-Type"": ""application/json"" }
                }).then(function (response) {
                    if (response.data == true) {
                        Swal.fire({
                            position: 'top-end',
                            type: 'success',
                            title: 'Your verification Mail has been sent.',
                            showConfirmButton: false,
                            timer: 3000
                        });
                       var timer = setTimeout(function() {
                           window.location.href = '");
            EndContext();
            BeginContext(3078, 26, false);
#line 67 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\Users\VerifyAccount.cshtml"
                                              Write(Url.Action("index","User"));

#line default
#line hidden
            EndContext();
            BeginContext(3104, 669, true);
            WriteLiteral(@"';
        }, 5000);

                    }
                    else
                    {
                        Swal.fire({
                            position: 'top-center',
                            type: 'info',
                            title: ""Email your entered is not found.Try with your registered Email!"",
                            showConfirmButton: false,
                            timer: 3000
                        });
                    }
                }, function (error) {
                    $window.alert(error);
                });

            }






                    });

                    </script>");
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
