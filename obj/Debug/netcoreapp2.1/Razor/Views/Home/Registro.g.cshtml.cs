#pragma checksum "D:\Documentos\PrograSem7\Programacion\Views\Home\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8486effa1019e0e19d79d13c7b0a064b690f0d3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registro), @"mvc.1.0.view", @"/Views/Home/Registro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registro.cshtml", typeof(AspNetCore.Views_Home_Registro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8486effa1019e0e19d79d13c7b0a064b690f0d3f", @"/Views/Home/Registro.cshtml")]
    public class Views_Home_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<programacion.models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(90, 308, true);
            WriteLiteral(@"<html>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
 <div class=""text-center"">
        <table>
            <tr>
                <td>");
            EndContext();
            BeginContext(399, 40, false);
#line 8 "D:\Documentos\PrograSem7\Programacion\Views\Home\Registro.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(439, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(467, 40, false);
#line 9 "D:\Documentos\PrograSem7\Programacion\Views\Home\Registro.cshtml"
               Write(Html.DisplayTextFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(507, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(572, 41, false);
#line 12 "D:\Documentos\PrograSem7\Programacion\Views\Home\Registro.cshtml"
               Write(Html.DisplayNameFor(model => model.Curso));

#line default
#line hidden
            EndContext();
            BeginContext(613, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(641, 41, false);
#line 13 "D:\Documentos\PrograSem7\Programacion\Views\Home\Registro.cshtml"
               Write(Html.DisplayTextFor(model => model.Curso));

#line default
#line hidden
            EndContext();
            BeginContext(682, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(747, 43, false);
#line 16 "D:\Documentos\PrograSem7\Programacion\Views\Home\Registro.cshtml"
               Write(Html.DisplayNameFor(model => model.Credito));

#line default
#line hidden
            EndContext();
            BeginContext(790, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(818, 43, false);
#line 17 "D:\Documentos\PrograSem7\Programacion\Views\Home\Registro.cshtml"
               Write(Html.DisplayTextFor(model => model.Credito));

#line default
#line hidden
            EndContext();
            BeginContext(861, 96, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Total</td>\r\n                <td>");
            EndContext();
            BeginContext(958, 43, false);
#line 21 "D:\Documentos\PrograSem7\Programacion\Views\Home\Registro.cshtml"
               Write(Html.DisplayTextFor(model => model.Credito));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 63, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<programacion.models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591