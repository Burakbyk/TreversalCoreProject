#pragma checksum "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6ec032cb3437de43a606ec7401e43e7b4c1838c0b684746cad83849cf5ab2a6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Information_Index), @"mvc.1.0.view", @"/Views/Information/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ec032cb3437de43a606ec7401e43e7b4c1838c0b684746cad83849cf5ab2a6c", @"/Views/Information/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"46e5407401c47e9f5eabc3a7f0ae9283ecfbaa688c6280f54cde099587a7a85b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Information_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Çoklu Dil Desteği</h4>
                <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                <div class=""heading-elements"">
                    <ul class=""list-inline mb-0"">
                        <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                        <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                        <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                        <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""card-content collapse show"">
                <div class=""card-body"">
                    <p class=""card-text"">");
#nullable restore
#line 25 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml"
                                    Write(localizer["Merhaba"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml"
                                                          Write(localizer["Bugün"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml"
                                                                              Write(localizer["Hava"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml"
                                                                                                 Write(localizer["Çok"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml"
                                                                                                                   Write(localizer["Güzel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h2>");
#nullable restore
#line 26 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml"
                   Write(localizer["Bize"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Information\Index.cshtml"
                                      Write(localizer["Ulaşın"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer﻿ { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591