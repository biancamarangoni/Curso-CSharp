#pragma checksum "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db474575fcbd0ed6b1e1a6af47941908072ec8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Index), @"mvc.1.0.view", @"/Views/Aluno/Index.cshtml")]
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
#line 1 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\_ViewImports.cshtml"
using MVCRazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\_ViewImports.cshtml"
using MVCRazorCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db474575fcbd0ed6b1e1a6af47941908072ec8c", @"/Views/Aluno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2c8090e596b78848a54e9bdc050b067fa383148", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
   
    var listaDeAlunos = ViewBag.ListaDeAlunos;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Aqui vamos criar nossa página de listagem de Alunos</h1>

<table class=""table table-striped table-responsive"">
    <thead>
    <th>Id</th>
    <th>Nome</th>
    <th>Email</th>
    <th>Endereço</th>
    <th>Telefone</th>
    <th>Escolaridade</th>
    <th>Ação</th>
    </thead>
");
#nullable restore
#line 17 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
     foreach (var item in listaDeAlunos)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
       Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
       Write(item.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
       Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
       Write(item.Escolaridade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 630, "\"", 682, 2);
            WriteAttributeValue("", 637, "https://localhost:44375/Aluno/Editar/", 637, 37, true);
#nullable restore
#line 27 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
WriteAttributeValue("", 674, item.Id, 674, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 710, "\"", 755, 2);
            WriteAttributeValue("", 717, "https://localhost:44375/Aluno/", 717, 30, true);
#nullable restore
#line 28 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
WriteAttributeValue("", 747, item.Id, 747, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\dev\Desktop\Bianca M\Curso-CSharp\ProjetoFinal\MVCRazorCRUD\Views\Aluno\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
