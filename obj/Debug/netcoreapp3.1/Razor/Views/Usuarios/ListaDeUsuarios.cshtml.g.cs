#pragma checksum "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdae7f803d0efbda9119a276ce5f1c401c233c38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
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
#line 1 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdae7f803d0efbda9119a276ce5f1c401c233c38", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários Cadastrados</h1>\r\n\r\n<p class=\"text-danger\">\r\n    ");
#nullable restore
#line 6 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
Write(ViewData["mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</p>

<table class=""table table-success table-striped"">
    <thead>
        <tr>
            <th scope=""row"">Nome</th>
            <th scope=""row"">Login</th>
            <th scope=""row"">Tipo</th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
           Write(u.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 24 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
             if(u.tipo==Usuario.ADMIN)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Administrador</td>\r\n");
#nullable restore
#line 27 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Padrão</td>\r\n");
#nullable restore
#line 31 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td><a");
            BeginWriteAttribute("href", " href=\"", 721, "\"", 750, 2);
            WriteAttributeValue("", 728, "editarUsuario?id=", 728, 17, true);
#nullable restore
#line 32 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 745, u.Id, 745, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">EDITAR</a></td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 783, "\"", 813, 2);
            WriteAttributeValue("", 790, "ExcluirUsuario?id=", 790, 18, true);
#nullable restore
#line 33 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 808, u.Id, 808, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">EXCLUIR</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\isaac\Downloads\Nova pasta\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a class=\"mt-5\" href=\"RegistrarUsuarios\">Fazer um novo Registro de Usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591