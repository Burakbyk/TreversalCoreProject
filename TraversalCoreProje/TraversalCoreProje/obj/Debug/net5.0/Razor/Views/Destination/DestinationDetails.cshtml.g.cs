#pragma checksum "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa20ebafab8e13ba85f0cf73b04e572c6c4b5cba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_DestinationDetails), @"mvc.1.0.view", @"/Views/Destination/DestinationDetails.cshtml")]
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
#line 1 "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa20ebafab8e13ba85f0cf73b04e572c6c4b5cba", @"/Views/Destination/DestinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747ec08a8964e833180d3bbf7df290b6369bf47d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destination_DestinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Destination>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
  
    ViewData["Title"] = "DestinationDetails";
    Layout = "/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa20ebafab8e13ba85f0cf73b04e572c6c4b5cba4163", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Traversal Travel Category Bootstrap Responsive Template | Blog Single </title>
    <!-- google fonts -->
    <link href=""//fonts.googleapis.com/css2?family=Montserrat:wght@300;400;600;700&display=swap"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css2?family=Lato:ital,wght@0,300;0,400;0,700;1,400&display=swap""
          rel=""stylesheet"">
    <!-- google fonts -->
    <!-- Template CSS -->
    <link rel=""stylesheet"" href=""/Traversal-Liberty/assets/css/style-liberty.css"">
    <!-- Template CSS -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa20ebafab8e13ba85f0cf73b04e572c6c4b5cba5836", async() => {
                WriteLiteral(@"

    <!-- about breadcrumb -->
    <section class=""w3l-about-breadcrumb text-left"">
        <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
            <div class=""container"">
                <h2 class=""title"">Tur Detayları</h2>
                <ul class=""breadcrumbs-custom-path mt-2"">
                    <li><a href=""/Default/Index"">Anasayfa</a></li>
                    <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rehberin Yorumları </li>
                </ul>
            </div>
        </div>
    </section>
    <!-- //about breadcrumb -->
    <!--/blog-->
    <div class=""py-5 w3l-homeblock1 text-center"">
        <div class=""container mt-md-3"">
            <h3 class=""blog-desc-big text-center mb-4"">
                Your Blog Posts are Boring? Here are 9 Tips for
                Making your Writing more Interesting
            </h3>
            <div class=""blog-post-align"">
                <div class=""blog-post-img"">
                 ");
                WriteLiteral("   <a href=\"#\"><img src=\"/Traversal-Liberty/assets/images/c1.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1985, "\"", 1991, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle img-fluid"" /></a>
                </div>
                <div class=""blog-post-info"">
                    <div class=""author align-items-center mb-1"">
                        <a href=""#"">Johnson smith</a> in <a href=""#url"">Traversal</a>
                    </div>
                    <ul class=""blog-meta"">
                        <li class=""meta-item blog-lesson"">
                            <span class=""meta-value""> June 13, 2020 </span>
                        </li>
                        <li class=""meta-item blog-students"">
                            <span class=""meta-value""> 6min read</span>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <section class=""blog-post-main w3l-homeblock1"">
        <!--/blog-post-->
        <div class=""blog-content-inf pb-5"">
            <div class=""container pb-lg-4"">
                <div class=""single-post-image"">
                    <div class=""post");
                WriteLiteral("-content\">\r\n                        <img src=\"/Traversal-Liberty/assets/images/banner2.jpg\" class=\"radius-image img-fluid mb-5\"");
                BeginWriteAttribute("alt", " alt=\"", 3143, "\"", 3149, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"single-post-content\">\r\n                    <p class=\"alphabet mb-4\">\r\n                        <span class=\"big-letter\">A</span>\r\n                        ");
#nullable restore
#line 80 "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                   Write(Model.Details1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>
                    <p class=""mb-4"">
                    
                    </p>
                    <blockquote class=""blockquote my-5"">
                        <div class=""icon-quote""><span class=""fa fa-quote-left"" aria-hidden=""true""></span></div>
                        ""Yolculuk, sadece yeni yerler keşfetmek değil, iç dünyamızı da keşfetme fırsatıdır.""
                        <footer class=""blockquote-footer mt-3"">
                            Smith lara
                        </footer>
                    </blockquote>
                 
                    <div class=""sing-post-thumb mb-5 row pt-3"">
                        <div class=""col-sm-6"">
                            <a href=""#url""><img src=""/Traversal-Liberty/assets/images/g8.jpg"" class=""img-fluid radius-image""");
                BeginWriteAttribute("alt", " alt=\"", 4229, "\"", 4235, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                        <div class=\"col-sm-6 mt-sm-0 mt-3\">\r\n                            <a href=\"#url\"><img src=\"/Traversal-Liberty/assets/images/g9.jpg\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 4460, "\"", 4466, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                    </div>\r\n                    <h3 class=\"blog-desc-big m-0 mb-lg-4 mb-3\">2. Paragraf</h3>\r\n                    <p class=\"mb-4\">\r\n                      ");
#nullable restore
#line 103 "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                 Write(Model.Details2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>

                   

                 

                    <div class=""d-grid left-right mt-5 pb-md-5"">
                        <div class=""buttons-singles tags"">
                            <h4>Tags :</h4>
                            <a href=""#blog-tag"">Travel</a>
                            <a href=""#blog-tag"">Culture</a>
                            <a href=""#blog-tag"">Hotel</a>
                            <a href=""#blog-tag"">Food</a>
                        </div>
                        <div class=""buttons-singles"">
                            <h4>Share :</h4>
                            <a href=""#blog-share""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-pint");
                WriteLiteral(@"erest-p"" aria-hidden=""true""></span></a>
                        </div>
                    </div>

                    <!--//author-card-->
                    <div class=""author-card mt-5"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-3 col-6"">
                                <div>
                                    <img src=""/Traversal-Liberty/assets/images/c3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6156, "\"", 6162, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle img-fluid"">
                                </div>
                            </div>
                            <div class=""col-sm-9 mt-sm-0 mt-3"">
                                <h3 class=""mb-3 title"">Alexander Ronald</h3>
                                <p>
                                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident, sed et excepturi.
                                    Distinctio fugit odit? Fugit ipsam. Lorem ipsum dolor sit.
                                </p>
                                <ul class=""author-icons mt-4"">
                                    <li>
                                        <a class=""facebook"" href=""#url"">
                                            <span class=""fa fa-facebook""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
            ");
                WriteLiteral(@"                            <a class=""twitter"" href=""#url"">
                                            <span class=""fa fa-twitter""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""google"" href=""#url"">
                                            <span class=""fa fa-google-plus""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""linkedin"" href=""#url"">
                                            <span class=""fa fa-linkedin""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
        ");
                WriteLiteral(@"                            <li>
                                        <a class=""github"" href=""#url"">
                                            <span class=""fa fa-github""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""dribbble"" href=""#url"">
                                            <span class=""fa fa-dribbble""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <!--//author-card-->


                    ");
#nullable restore
#line 185 "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
               Write(await Component.InvokeAsync("_CommentList",new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 187 "C:\Users\Burak\Desktop\GitHub-Projects\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
               Write(await Html.PartialAsync("/Views/Comment/AddComment.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                   \r\n                </div>\r\n            </div>\r\n            <!--//blog-post-->\r\n        </div>\r\n        </section>\r\n\r\n  \r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\ns");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Destination> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
