#pragma checksum "C:\Users\gianL\OneDrive\Área de Trabalho\Atvdd2_Uc04\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27818cf6f5e9f9796772cdfbb4e361f020930d5b"
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
#line 1 "C:\Users\gianL\OneDrive\Área de Trabalho\Atvdd2_Uc04\Views\_ViewImports.cshtml"
using Atvdd2_Uc04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gianL\OneDrive\Área de Trabalho\Atvdd2_Uc04\Views\_ViewImports.cshtml"
using Atvdd2_Uc04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27818cf6f5e9f9796772cdfbb4e361f020930d5b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbc6ea2f150e44a9ef9bb746864d50337eb42304", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagens/Paris.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Paris"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagens/machu.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagens/canyon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagens/caribe.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagens/dub.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gianL\OneDrive\Área de Trabalho\Atvdd2_Uc04\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body,
    html {
        width: 100%;
        height: 100%;
        font-family: sans-serif;
        position: absolute;
    }

    body {
        background: url('../imagens/fundo.jpg') repeat center center;
        /* */
        background-size: cover;
        color: #fff;
    }

    .cont {
        width: 100%;
        height: 100%;
        display: flex;
        overflow: inherit;
        align-items: center;
        padding: 150px;

    }

    .Th1 {

        margin: 10px;
        margin-left: 80px;
        width: 280px;
        height: 28px;
        background-color: #AB0AC7;
        display: flex;

    }

    .Th1 h1 {
        margin-top: -2px;
        margin-left: 90px;
        font-size: 54px;
        font-weight: bold;
    }


    .pacoteviagem {
        flex-shrink: 0;
        width: 360px;
        height: 480px;
        border-radius: 20px;
        border: 10px #AB0AC7;
        box-shadow: 0 0 99px 0 rgba(0, 0, 0, 1);
        display:");
            WriteLiteral(@" flex;
        flex-direction: column;
        justify-content: space-between;
        background-color: #7AA7C6;
        padding: 30px;
        font-size: 10px;
        margin-left: -170px;
        margin-top: 10px;
        transition: 0.9s;
        overflow: hidden;
        position: relative;
    }

    .imgpacote img {
        width: 140px;
        height: 140px;
        border-radius: 20px;
        background-color: black;
    }

    img {

        margin-left: 80px;
    }

    .descricao {

        width: 320px;
        height: 110px;
        text-align: center;
        background-color: #1766D6;
        opacity: 88%;
        justify-content: space-between;
        border-radius: 20px;
        box-shadow: 3 3 99px 3 (#7AA7C6);
    }

    .descricao p {
        margin-top: 12px;
        color: #D9D2DD;
        font-weight: bold;
    }

    p {
        font-weight: bold;
        text-align: center;
        
        color: #D9D2DD;
    }

    .pacoteviagem:");
            WriteLiteral(@"hover {
        transform: translateY(-20px);
        margin-right: 120px;
        box-shadow: 0 0 99px 0 rgba(0, 0, 0, 1);
        border: 10px #AB0AC7;
        cursor: pointer;
    }

    .botao {
        margin: auto;
        width: 100px;
    }

    input {
        align-items: center;
        width: 100px;
        height: 30px;
        background: #1766D6;
        font-size: 12px bold;
        color: #fff;
        border: none;
    }

    .botao input:hover {
        cursor: pointer;
        color: #D9D2DD;
        transform: translateY(8px);
    }
</style>

<div class=""Th1"">
    <h1>Travel Line Turismo</h1>
</div>

<div class=""cont"">

    <div class=""pacoteviagem"">

        <h2>Lua de Mel em Paris</h2>

        <br>

        <div class=""imgpacote"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27818cf6f5e9f9796772cdfbb4e361f020930d5b9041", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <br>

        <div class=""descricao"">
            <p>Aprecie a linda Paris na companhia de quem você mais gosta.
                Preços e condicões especiais para você e seu parceiro desfrutarem de uma viagem inesquecivel. Conheça
                novas
                paisagens, museus, e
                uma cultura única. Não perca essa oportunidade, faça agora mesmo a compra do seu pacote e aproveite
                condições especiais.</p>
        </div>

        <div class=""valorpacote"">
            <p><b>R$ 2.300,00</b> Com hospedagem e guia turístico incluso</p>
            <p><b>Ou até 12x de R$230,00</b> No Cartão de crédito</p>
        </div>

        <div class=""botao"">
            <input type=""submit"" value=""Comprar"">
        </div>

    </div>

    <div class=""pacoteviagem"">

        <h2>Tour Machu Pitcchu </h2>

        <br>

        <div class=""imgpacote"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27818cf6f5e9f9796772cdfbb4e361f020930d5b11284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <br>

        <div class=""descricao"">
            <p>Participe de trilhas, escaladas, e travessias por rotas e caminhos da antiga sociedade Inca,
                veja de perto as ruínas e a história do que um dia já foi uma das mais incríveis civilizações
                já existente. Adiquira já o seu pacote
            </p>
        </div>

        <div class=""valorpacote"">
            <p><b>R$ 1.800,00</b> Com hospedagem, guia turístico incluso, <b>condicões especiais para estudantes</b></p>
            <p><b>Ou até 12x de R$180,00</b> No Cartão de crédito</p>
        </div>

        <div class=""botao"">
            <input type=""submit"" value=""Comprar"">
        </div>

    </div>


    <div class=""pacoteviagem"">

        <h2>Tour Grand Canyon</h2>

        <br>

        <div class=""imgpacote"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27818cf6f5e9f9796772cdfbb4e361f020930d5b13450", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <br>

        <div class=""descricao"">
            <p>Venha conhecer uma das maravilhas do Arizona. Um cartão postal para os
                amantes das paisagens e da adrenalina, desfrute de atividades como caminhadas e trilhas
                além de um camping completamente preparado para você. Uma aventura que você não pode
                ficar de fora.
            </p>
        </div>

        <div class=""valorpacote"">
            <p><b>R$ 2.100,00</b> Camping e guias de trilha incluso</p>
            <p><b>Ou até 12x de R$210,00</b> No Cartão de crédito</p>
        </div>

        <div class=""botao"">
            <input type=""submit"" value=""Comprar"">
        </div>

    </div>

    <div class=""pacoteviagem"">

        <h2>Férias no Caribe</h2>

        <br>

        <div class=""imgpacote"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27818cf6f5e9f9796772cdfbb4e361f020930d5b15614", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <br>

        <div class=""descricao"">
            <p>Não perca a oportunidade de conhecer uma das praias mais paradisíacas do planeta. Venha repousar seu corpo
                e alma em um ambiente completamente utópico com paisagens surreais. Aproveite o melhor serviço de hospedagem
                da região e saboreie uma culinária ímpar, com sabores exóticos e únicos.
            </p>
        </div>

        <div class=""valorpacote"">
            <p><b>R$ 4.200,00</b> Com hospedagem e guia turístico incluso</p>
            <p><b>Ou até 12x de R$420,00</b> No Cartão de crédito</p>
        </div>

        <div class=""botao"">
            <input type=""submit"" value=""Comprar"">
        </div>

    </div>


    <div class=""pacoteviagem"">

        <h2>Férias em Dubai</h2>

        <br>

        <div class=""imgpacote"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27818cf6f5e9f9796772cdfbb4e361f020930d5b17798", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <br>

        <div class=""descricao"">
            <p>Quem nunca sonhou em visitar a cidade do futuro? A hora chegou, aproveite nossos pacotes e embarque em uma viagemdo
                dos sonhos, conheça locais unicos,e curiosidades que nunca encontrará em nenhum outro lugar do mundo. A terra da riqueza
                e da promissão te aguarda com uma cultura incrível em um lugar inimaginável. 
            </p>
        </div>

        <div class=""valorpacote"">
            <p><b>R$ 4.800,00</b> Com hospedagem e guia turístico incluso</p>
            <p><b>Ou até 12x de R$480,00</b> No Cartão de crédito</p>
        </div>

        <div class=""botao"">
            <input type=""submit"" value=""Comprar"">
        </div>

    </div>
</div>
");
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