#pragma checksum "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab8061c622af0cf226398cdcd8fa3a7314a29e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estudiantes_Detalle), @"mvc.1.0.view", @"/Views/Estudiantes/Detalle.cshtml")]
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
#line 1 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\_ViewImports.cshtml"
using PrimeraWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\_ViewImports.cshtml"
using PrimeraWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab8061c622af0cf226398cdcd8fa3a7314a29e30", @"/Views/Estudiantes/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77be1819c600b33fc821aa1e8c093982d83bda6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Estudiantes_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrimeraWeb.Models.Estudiantes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MostrarEstudiantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
  

    ViewData["Title"] = "Detalle Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"Estiloall\">\r\n    <h3 class=\"EstiloH3 text-light\">Detalle de Estudiantes</h3>\r\n    <div class=\"EstiloSection\">\r\n        <div class=\"EstiloContenedorButtonRegresar\">\r\n            <button class=\"EstiloButton\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab8061c622af0cf226398cdcd8fa3a7314a29e303803", async() => {
                WriteLiteral("Regresar al listado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n        </div>\r\n        <div class=\"EstiloText\">\r\n            <div class=\"EstiloPaddin\">\r\n                <div class=\"text-light\">\r\n                    Codigo: ");
#nullable restore
#line 16 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                       Write(Model.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"text-light\">\r\n                    Nombre: ");
#nullable restore
#line 19 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"text-light\">\r\n                    Nota1: ");
#nullable restore
#line 22 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                      Write(Model.Nota1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"text-light\">\r\n                    Nota2: ");
#nullable restore
#line 25 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                      Write(Model.Nota2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"text-light\">\r\n                    Nota3: ");
#nullable restore
#line 28 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                      Write(Model.Nota3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div class=\"text-light\">\r\n            </div>\r\n            <div class=\"EstiloButtons\">\r\n\r\n");
#nullable restore
#line 33 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                 if (User.IsInRole("administrador") || User.IsInRole("profesor"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"EstiloButton fondoboton\">\r\n                        ");
#nullable restore
#line 36 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                   Write(Html.ActionLink("Editar", "Editar", new {id = Model.Codigo}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 38 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                 if (User.IsInRole("administrador"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"EstiloButton fondoboton\">\r\n                        ");
#nullable restore
#line 43 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                   Write(Html.ActionLink("Borrar", "Borrar", new{id = Model.Codigo}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 45 "D:\WebApp\PrimeraWeb\PrimeraWeb\Views\Estudiantes\Detalle.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrimeraWeb.Models.Estudiantes> Html { get; private set; }
    }
}
#pragma warning restore 1591
