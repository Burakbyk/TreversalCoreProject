#pragma checksum "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7caa5d7a74535d747f33a0cb27f49363144c4ccc83326ab229f40da3264e1176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DestinationCQRS_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
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
#line 1 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7caa5d7a74535d747f33a0cb27f49363144c4ccc83326ab229f40da3264e1176", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f90e0cd077d4c2786d11d522f45a72e258e5d79beafa265ecfd31e5b7c890a43", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_DestinationCQRS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAlllDestinationQueryResult>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>CQRS Tur Rotası Verileri</h2>

<br />
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Şehir</th>
        <th>Gün-Gece</th>
        <th>Fiyat</th>
        <th>Kapasite</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.daynight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 697, "\"", 753, 2);
            WriteAttributeValue("", 704, "/Admin/DestinationCQRS/DeleteDestination/", 704, 41, true);
#nullable restore
#line 30 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 745, item.id, 745, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 818, "\"", 871, 2);
            WriteAttributeValue("", 825, "/Admin/DestinationCQRS/GetDestination/", 825, 38, true);
#nullable restore
#line 31 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 863, item.id, 863, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Burak\Documents\GitHub\TreversalCoreProject\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/DestinationCQRS/AddDestination/\" class=\"btn btn-outline-primary\">Yeni Tur Rotası Girişi</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAlllDestinationQueryResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
