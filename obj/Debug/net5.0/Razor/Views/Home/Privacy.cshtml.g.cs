#pragma checksum "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e0c952501c2df4e74b34f6587aaf51cd7a875ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\_ViewImports.cshtml"
using practica04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\_ViewImports.cshtml"
using practica04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e0c952501c2df4e74b34f6587aaf51cd7a875ff", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16e68778de4f9b00be72e30f5beb27272e833425", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n   \r\n");
#nullable restore
#line 9 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml"
         foreach (var usuario in Model)
        {
           


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4 \">\r\n<p><strong> id : </strong> ");
#nullable restore
#line 14 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml"
                      Write(usuario.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 <p><strong> Titulo : </strong> ");
#nullable restore
#line 15 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml"
                                           Write(usuario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 <p><strong>Subido por : </strong> ");
#nullable restore
#line 16 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml"
                                              Write(usuario.nombreusuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 <p><strong>Comentario : </strong> ");
#nullable restore
#line 17 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml"
                                              Write(usuario.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 <img");
            BeginWriteAttribute("src", "  src=\"", 438, "\"", 458, 1);
#nullable restore
#line 18 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 445, usuario.foto, 445, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"  /> \r\n\r\n\r\n  \r\n\r\n\r\n\r\n            \r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\joseo\OneDrive\Escritorio\practica04\Views\Home\Privacy.cshtml"

                
        


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
