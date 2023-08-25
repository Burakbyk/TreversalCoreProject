#pragma checksum "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f053a95b83be088f7c405cd388cb547b5b24c7fc7e49b1a0ee1e947e18a2599c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__LastDestinations_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_LastDestinations/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using DTOLayer.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f053a95b83be088f7c405cd388cb547b5b24c7fc7e49b1a0ee1e947e18a2599c", @"/Views/Shared/Components/_LastDestinations/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"46e5407401c47e9f5eabc3a7f0ae9283ecfbaa688c6280f54cde099587a7a85b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__LastDestinations_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"


<div class=""col-12 mt-4"">
    <div class=""card mb-4"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-1"">Son Rotalar</h6>
            <p class=""text-sm"">Traversal Şirketinin En Son Eklenen Seyahat Rotaları</p>
        </div>
        <div class=""card-body p-3"">
            <div class=""row"">
");
#nullable restore
#line 13 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml"
               foreach (var item in Model)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-xl-3 col-md-6 mb-xl-0 mb-4"">
                    <div class=""card card-blog card-plain"">
                        <div class=""position-relative"">
                            <a class=""d-block shadow-xl border-radius-xl"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 705, "\"", 722, 1);
#nullable restore
#line 19 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml"
WriteAttributeValue("", 711, item.Image, 711, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:400px; height:200px;"" alt=""img-blur-shadow"" class=""img-fluid shadow border-radius-xl"">
                            </a>
                        </div>
                        <div class=""card-body px-1 pb-0"">
                            <p class=""text-gradient text-dark mb-2 text-sm"">");
#nullable restore
#line 23 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                                                       Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 23 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</p>\r\n                            <a href=\"javascript:;\">\r\n                                <h5>\r\n                                    ");
#nullable restore
#line 26 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml"
                               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h5>\r\n                            </a>\r\n                            <p class=\"mb-4 text-sm\">\r\n                                ");
#nullable restore
#line 30 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml"
                           Write(item.Details2.Substring(0,100));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                            </p>\r\n                            <div class=\"d-flex align-items-center justify-content-between\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1557, "\"", 1615, 2);
            WriteAttributeValue("", 1564, "/Destination/DestinationDetails/", 1564, 32, true);
#nullable restore
#line 33 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml"
WriteAttributeValue("", 1596, item.DestinationID, 1596, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary btn-sm mb-0"">Tur Detayları</a>
                                <div class=""avatar-group mt-2"">
                                    <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Elena Morison"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f053a95b83be088f7c405cd388cb547b5b24c7fc7e49b1a0ee1e947e18a2599c10323", async() => {
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
            WriteLiteral(@"
                                    </a>
                                    <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Ryan Milly"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f053a95b83be088f7c405cd388cb547b5b24c7fc7e49b1a0ee1e947e18a2599c11725", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                    <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Nick Daniel"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f053a95b83be088f7c405cd388cb547b5b24c7fc7e49b1a0ee1e947e18a2599c13128", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </a>\r\n                                    <a href=\"javascript:;\" class=\"avatar avatar-xs rounded-circle\" data-bs-toggle=\"tooltip\" data-bs-placement=\"bottom\" title=\"Peterson\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f053a95b83be088f7c405cd388cb547b5b24c7fc7e49b1a0ee1e947e18a2599c14533", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_LastDestinations\Default.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591