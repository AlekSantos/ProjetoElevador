#pragma checksum "C:\Users\Alek\source\repos\ProjetoElevador\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44a70e58cd7e3afdbcaa5e50711272e5f12ddbc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Alek\source\repos\ProjetoElevador\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alek\source\repos\ProjetoElevador\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a70e58cd7e3afdbcaa5e50711272e5f12ddbc7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4923143fe3bec400c1f93c72fde12f2bac68e920", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alek\source\repos\ProjetoElevador\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Bem vindo a documenta??ao do ProjetoElevador</h1>
    <h2>O ProjetoElevador ?? um projeto em que temos uma classe chamada Elevador na pasta models.
        A classe Elevador tem 4 atributos inteiros(int) que ??
        andarAtual em que o elevador vai se encontrar,
        a quantidadeDePessoas que vai ser quantas pessoas tem dentro do elevador naquele momento,
        a capacidadeElevador que ?? quantas pessoas esse elevador suporta no maximo e
        o totalDeAndares que ?? quantos andares tem aquele predio.
        existem 5 metodos nesse classe , o primeiro metodo ?? o Inicializar que vai iniciar os valores dos atributos,a capacidade do elevador e total de andares o usuario digita e 
        quantidade de pessoas e o andar atual sao iniciados em zero.
        O metodo subir acrescenta 1 ao atributo andarAtual , ou seja faz o elevador subir um andar(se nao estiver no ultimo andar),
        O metodo descer decresce 1 ao atributo andarAtual , ou sej");
            WriteLiteral(@"a faz o elevador descer um andar(se nao estiver no terreo),
        O metodo Entrar acrescenta 1 ao atributo quantidadeDePessoas , ou seja acrescenta um a quantidade de pessoas dentro do elevador(nao faz isso se o elevador tiver atingido a capacidade maxima),
        o metodo sair decresce 1 ao atributo quantidadeDePessoas,ou seja decresce um a quantidade de pessoas dentro do elevador(se estiver vazio nao acontece nada).
        Para mais informa??oes abra o codigo e siga os comentarios feitos.

        Ass: Alekssander Santos do Carmo Martins.
    </h2>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
