#pragma checksum "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\Futbolcular2122Eng\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7070086241338a81063887200abfee167099c8b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Futbolcular2122Eng_Index2), @"mvc.1.0.view", @"/Views/Futbolcular2122Eng/Index2.cshtml")]
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
#line 1 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\_ViewImports.cshtml"
using siCore2.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\_ViewImports.cshtml"
using siCore2.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7070086241338a81063887200abfee167099c8b4", @"/Views/Futbolcular2122Eng/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6745f2abba2003698248445659f0c1cf67bb74ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Futbolcular2122Eng_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<siCoreDBF3.DAL.Model.Futbolcular2122Eng>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\Futbolcular2122Eng\Index2.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""tableName"">2021/2022 ASİST KRALLIĞI</h3>
<div class=""table-wrapper"">
    <table class=""fl-table"">
        <thead>
            <tr>
                <th>Futbolcu</th>
                <th>Asist Sayısı</th>
                <th>Takım</th>

            </tr>
        </thead>
");
#nullable restore
#line 18 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\Futbolcular2122Eng\Index2.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 22 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\Futbolcular2122Eng\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.FutbolcuIsim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\Futbolcular2122Eng\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.YapilanAsist));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\Futbolcular2122Eng\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.Takim.TakimAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\Futbolcular2122Eng\Index2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<siCoreDBF3.DAL.Model.Futbolcular2122Eng>> Html { get; private set; }
    }
}
#pragma warning restore 1591
