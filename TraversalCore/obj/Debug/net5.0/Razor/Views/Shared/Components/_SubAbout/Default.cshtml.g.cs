#pragma checksum "C:\Users\user\Desktop\TraversalCore\TraversalCore\TraversalCore\Views\Shared\Components\_SubAbout\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6051c82b150d220bebddee04506faaf71e0d7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__SubAbout_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_SubAbout/Default.cshtml")]
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
#line 1 "C:\Users\user\Desktop\TraversalCore\TraversalCore\TraversalCore\Views\_ViewImports.cshtml"
using TraversalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\TraversalCore\TraversalCore\TraversalCore\Views\_ViewImports.cshtml"
using TraversalCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Desktop\TraversalCore\TraversalCore\TraversalCore\Views\Shared\Components\_SubAbout\Default.cshtml"
using TraversalCore.Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6051c82b150d220bebddee04506faaf71e0d7e", @"/Views/Shared/Components/_SubAbout/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ade48aa8f0f1d0e8a44f16fe971eb62108965c43", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__SubAbout_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SubAbout>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/traversal-starter/about.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-style btn-secondary mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral(@"<section class=""w3l-bottom py-5"">
    <div class=""container py-md-4 py-3 text-center"">
        <div class=""row my-lg-4 mt-4"">
            <div class=""col-lg-9 col-md-10 ml-auto"">
                <div class=""bottom-info ml-auto"">
                    <div class=""header-section text-left"">
");
#nullable restore
#line 9 "C:\Users\user\Desktop\TraversalCore\TraversalCore\TraversalCore\Views\Shared\Components\_SubAbout\Default.cshtml"
                         foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3 class=\"hny-title two\">");
#nullable restore
#line 10 "C:\Users\user\Desktop\TraversalCore\TraversalCore\TraversalCore\Views\Shared\Components\_SubAbout\Default.cshtml"
                                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"mt-3 pr-lg-5\">\r\n                           ");
#nullable restore
#line 12 "C:\Users\user\Desktop\TraversalCore\TraversalCore\TraversalCore\Views\Shared\Components\_SubAbout\Default.cshtml"
                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 14 "C:\Users\user\Desktop\TraversalCore\TraversalCore\TraversalCore\Views\Shared\Components\_SubAbout\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6051c82b150d220bebddee04506faaf71e0d7e5871", async() => {
                WriteLiteral("Daha Fazlası");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SubAbout>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
