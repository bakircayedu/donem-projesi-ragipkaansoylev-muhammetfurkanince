#pragma checksum "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca9bf5e6fb07148c0581b71f290ff3dd7528a597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_F120Pilotlar_Index), @"mvc.1.0.view", @"/Views/F120Pilotlar/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca9bf5e6fb07148c0581b71f290ff3dd7528a597", @"/Views/F120Pilotlar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6745f2abba2003698248445659f0c1cf67bb74ac", @"/Views/_ViewImports.cshtml")]
    public class Views_F120Pilotlar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<siCoreDBF3.DAL.Model.F120Pilotlar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""tableName""> FORMULA 1 2020 PİLOTLAR SIRALAMASI</h3>
<div class=""table-wrapper"">
    <table class=""fl-table"">
        <thead>
            <tr>
                 <th>PILOT</th>
                <th>TAKIM</th>
                <th>GALIBIYET</th>
                <th>POLE</th>
                <th>PODYUM</th>
                <th>PUAN</th>

            </tr>
        </thead>
        <tbody>





");
#nullable restore
#line 27 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr> <td>\r\n                        ");
#nullable restore
#line 30 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Pilot.PilotName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Takim.TakimAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Win));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PolePosition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Podium));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Puan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\kaans\source\repos\siCoreDBF\siCore2.MVC\Views\F120Pilotlar\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<siCoreDBF3.DAL.Model.F120Pilotlar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
