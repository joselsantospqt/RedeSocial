#pragma checksum "C:\Git\.NET-5-REST-API\RedeSocial\RedeSocialWeb\Views\Perfil\EditarPerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a502f7fa59fcaa91e12f14356cd6010171ae519"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_EditarPerfil), @"mvc.1.0.view", @"/Views/Perfil/EditarPerfil.cshtml")]
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
#line 1 "C:\Git\.NET-5-REST-API\RedeSocial\RedeSocialWeb\Views\_ViewImports.cshtml"
using RedeSocialWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\.NET-5-REST-API\RedeSocial\RedeSocialWeb\Views\_ViewImports.cshtml"
using RedeSocialWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a502f7fa59fcaa91e12f14356cd6010171ae519", @"/Views/Perfil/EditarPerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bbee9bdb00112c0096efe577be0bf2c1aad58ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_EditarPerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--inicio content-->
<main class=""page-content"">

    <div class=""profile-cover bg-dark""></div>

    <div class=""row"">
        <div class=""col-12 col-lg-8"">
            <div class=""card shadow-sm border-0"">
                <div class=""card-body"">
                    <h5 class=""mb-0"">Seu perfil</h5>
                    <hr>
                    <div class=""card shadow-none border"">
                        <div class=""card-header"">
                            <h6 class=""mb-0"">INFORMAÇÃO DO USUÁRIO</h6>
                        </div>
                        <div class=""card-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a502f7fa59fcaa91e12f14356cd6010171ae5194239", async() => {
                WriteLiteral(@"
                                <div class=""col-6"">
                                    <label class=""form-label"">Apelido</label>
                                    <input type=""text"" class=""form-control"" value=""NomeDoUsuário"">
                                </div>
                                <div class=""col-6"">
                                    <label class=""form-label"">Email</label>
                                    <input type=""text"" class=""form-control"" value=""xpto@hotmail.com.br"">
                                </div>
                                <div class=""col-12"">
                                    <label class=""form-label"">Nome</label>
                                    <input type=""text"" class=""form-control"" value=""Nome do usuário"">
                                </div>

                                <div class=""col-12"">
                                    <label for=""perfilFoto"" class=""col-sm-12 col-form-label"">Foto do perfil:</label>
                            ");
                WriteLiteral("        <div class=\"col-sm-12\">\r\n                                        <input type=\"file\" class=\"form-control\" id=\"perfilFoto\">\r\n                                    </div>\r\n                                </div>\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""card shadow-none border"">
                        <div class=""card-header"">
                            <h6 class=""mb-0"">OUTRAS INFORMAÇÔES</h6>
                        </div>
                        <div class=""card-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a502f7fa59fcaa91e12f14356cd6010171ae5197264", async() => {
                WriteLiteral(@"
                                <div class=""col-6"">
                                    <label class=""form-label"">Bairro</label>
                                    <input type=""text"" class=""form-control"" value=""Barra da Aldeia"">
                                </div>
                                <div class=""col-6"">
                                    <label class=""form-label"">Cidade</label>
                                    <input type=""text"" class=""form-control"" value=""Cassemiro de Abreu"">
                                </div>
                                <div class=""col-3"">
                                    <label class=""form-label"">Sua idade</label>
                                    <input type=""text"" class=""form-control"" value=""27 anos"">
                                </div>
                                <div class=""col-3"">
                                    <label class=""form-label"">Estado</label>
                                    <input type=""text"" class=""form-control");
                WriteLiteral(@""" value=""RJ"">
                                </div>
                                <div class=""col-6"">
                                    <label class=""form-label"">Pais</label>
                                    <input type=""text"" class=""form-control"" value=""Brasil"">
                                </div>

                                <div class=""col-12"">
                                    <label class=""form-label"">Sobre você</label>
                                    <textarea class=""form-control"" rows=""4"" cols=""4"" placeholder=""Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi""></textarea>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""text-start"">
                        <button type=""button"" class=""btn btn-primary px-4"">Salvar alterações</button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-12 col-lg-4"">
            <div class=""card shadow-sm border-0 overflow-hidden"">
                <div class=""card-body"">
                    <div class=""profile-avatar text-center"">
                        <img src=""https://via.placeholder.com/110X110"" class=""rounded-circle shadow"" width=""120"" height=""120""");
            BeginWriteAttribute("alt", " alt=\"", 4795, "\"", 4801, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""d-flex align-items-center justify-content-around mt-5 gap-3"">
                        <div class=""text-center"">
                            <h4 class=""mb-0"">150</h4>
                            <p class=""mb-0 text-secondary"">Amigos</p>
                        </div>
                        <div class=""text-center"">
                            <h4 class=""mb-0"">25</h4>
                            <p class=""mb-0 text-secondary"">Fotos</p>
                        </div>
                        <div class=""text-center"">
                            <h4 class=""mb-0"">13</h4>
                            <p class=""mb-0 text-secondary"">Trilhas publicadas</p>
                        </div>
                    </div>
                    <div class=""text-center mt-4"">
                        <h4 class=""mb-1"">Nome do usuário, 27 anos</h4>
                        <p class=""mb-0 text-secondary"">Cassemiro de Abreu, Rio de Janeiro</p>
               ");
            WriteLiteral("         <div class=\"mt-4\"></div>\r\n                    </div>\r\n                    <hr>\r\n                    <div class=\"text-start\">\r\n                        <h5");
            BeginWriteAttribute("class", " class=\"", 5988, "\"", 5996, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sobre</h5>
                        <p class=""mb-0"">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi
                    </div>
                </div>
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item d-flex justify-content-between align-items-center bg-transparent border-top"">
                        Trilhas confirmadas
                        <span class=""badge bg-primary rounded-pill"">45</span>
                    </li>
                    <li>
                        <div class=""col py-4 text-center"">
                            <a href=""/perfil/excluirconta""><button type=""button"" class=""btn btn-sm btn-danger px-5"">Excluir conta</button></a>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <!--fim row-->

</mai");
            WriteLiteral("n>\r\n<!--fim main-->");
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
