#pragma checksum "C:\LanchesMac\LanchesMac\Views\Shared\_LanchesResumoView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c601af52f47ce7e1d8d2a878b3de0ef5c2c6f2ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LanchesResumoView), @"mvc.1.0.view", @"/Views/Shared/_LanchesResumoView.cshtml")]
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
#line 1 "C:\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c601af52f47ce7e1d8d2a878b3de0ef5c2c6f2ed", @"/Views/Shared/_LanchesResumoView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c3015c2164638f4de89da923f14829a5162d1b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LanchesResumoView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lanche>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n            <div class=\"thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 74, "\"", 96, 1);
#nullable restore
#line 4 "C:\LanchesMac\LanchesMac\Views\Shared\_LanchesResumoView.cshtml"
WriteAttributeValue("", 80, Model.ImagemUrl, 80, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-rounded\"");
            BeginWriteAttribute("alt", " alt=\"", 117, "\"", 123, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-righ\"> ");
#nullable restore
#line 8 "C:\LanchesMac\LanchesMac\Views\Shared\_LanchesResumoView.cshtml"
                                  Write(Model.Preco.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h3> ");
#nullable restore
#line 9 "C:\LanchesMac\LanchesMac\Views\Shared\_LanchesResumoView.cshtml"
                Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                <p>");
#nullable restore
#line 11 "C:\LanchesMac\LanchesMac\Views\Shared\_LanchesResumoView.cshtml"
              Write(Model.DescricaoCurta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lanche> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
