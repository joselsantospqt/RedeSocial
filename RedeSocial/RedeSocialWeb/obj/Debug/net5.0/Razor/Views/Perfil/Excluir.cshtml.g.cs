#pragma checksum "C:\Git\.NET-5-REST-API\RedeSocial\RedeSocialWeb\Views\Perfil\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2143212059a59bc6127c3d265ed328191d6a085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Excluir), @"mvc.1.0.view", @"/Views/Perfil/Excluir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2143212059a59bc6127c3d265ed328191d6a085", @"/Views/Perfil/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bbee9bdb00112c0096efe577be0bf2c1aad58ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral(@" <!--incio conteudo-->
<main class=""page-content"">

    <div class=""profile-cover bg-dark"">
        <div class=""alert border-0 bg-danger alert-dismissible fade show py-2 mt-5"">
            <div class=""d-flex align-items-center"">
                <div class=""fs-3 text-white"">
                    <i class=""bi bi-x-circle-fill""></i>
                </div>
                <div class=""ms-3"">
                    <div class=""text-white"">A remoção da conta é permanente e irreversível. Após a remoção bem-sucedida, você não poderá fazer login com essa atual conta.</div>
                </div>
            </div>
            <button type=""button"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close""></button>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-12 col-lg-8 mx-auto"">
            <div class=""card shadow-sm border-0"">
                <div class=""card-body"">
                    <h3 class=""mb-0 text-center"">
                        ATENÇÃO USUÁRIO</h5>
        ");
            WriteLiteral(@"                <h6 class=""my-4 text-center"">
                            Antes de realizar o procedimento, você deve saber que <strong>deletar</strong> a conta<br> é <strong>irreversível</strong> e irá <strong>apagar</strong> todas as suas trilhas, informações do perfil e fotos!
                        </h6>
                        <div class=""card shadow-none border"">
                            <div class=""card-header"">
                                <h6 class=""mb-0 text-center"">EXCLUSÃO DE CONTA</h6>
                            </div>
                            <div class=""card-body"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2143212059a59bc6127c3d265ed328191d6a0855301", async() => {
                WriteLiteral(@"
                                    <div class=""col-6"">
                                        <label class=""form-label"">Informe a sua senha</label>
                                        <input class=""form-control "" id=""senhaAcesso"" placeholder=""Senha"">
                                    </div>
                                    <div class=""col-6"">
                                        <label class=""form-label"">Confirme a sua senha</label>
                                        <input class=""form-control "" id=""senhaAcesso"" placeholder=""Digite novamente a senha"">
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
            WriteLiteral("\r\n                                <div class=\"text-center mt-4\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2457, "\"", 2464, 0);
            EndWriteAttribute();
            WriteLiteral(@"><button type=""button"" class=""btn btn-danger px-4 w-100"">Excluir conta</button></a>
                                    <a href=""/feed/index""><button type=""button"" class=""btn btn-outline-secondary px-4 w-100 mt-2"">Voltar</button></a>
                                </div>


                            </div>
                        </div>

                </div>
            </div>
        </div>

    </div>
    <!--fim row-->

</main>
<!--fim main-->
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
