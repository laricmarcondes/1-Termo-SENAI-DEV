#pragma checksum "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07c49014130c53189773bd29a716e608653db14a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroEvento_Evento), @"mvc.1.0.view", @"/Views/CadastroEvento/Evento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CadastroEvento/Evento.cshtml", typeof(AspNetCore.Views_CadastroEvento_Evento))]
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
#line 1 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c49014130c53189773bd29a716e608653db14a", @"/Views/CadastroEvento/Evento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroEvento_Evento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.CadastroEventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
  
    ViewData["Title"] = "Cadastro de ventos - Rolê Top";

#line default
#line hidden
            BeginContext(119, 108, true);
            WriteLiteral("\r\n<h2><i>Área do cliente</i></h2>\r\n\r\n    <br />\r\n\r\n<div class=\"nome-e-foto-do-cliente\">\r\n        <p><strong>");
            EndContext();
            BeginContext(228, 17, false);
#line 11 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
              Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(245, 184, true);
            WriteLiteral("</strong></p>\r\n        <img src=\"/img/sem_foto_perfil.png\" style=\"width: 3em\" alt=\"sem foto\" title=\"sem foto\">\r\n</div>\r\n\r\n        <br />\r\n\r\n<main>\r\n    <h3>Agende seu evento</h3>\r\n    ");
            EndContext();
            BeginContext(429, 3974, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07c49014130c53189773bd29a716e608653db14a5077", async() => {
                BeginContext(501, 149, true);
                WriteLiteral("\r\n        <div>\r\n                <label for=\"nome\"><i>Nome Completo</i></label>\r\n                <br />\r\n                <input id=\"nome\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value =\"", 650, "\"", 678, 1);
#line 23 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
WriteAttributeValue("", 659, Model.Cliente.Nome, 659, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(679, 202, true);
                WriteLiteral(" name=\"cliente_nome\" />\r\n        </div>\r\n\r\n        <br />\r\n\r\n        <div>\r\n                <label for=\"email\"><i>Email</i></label>\r\n                <br />\r\n                <input id=\"email\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value =\"", 881, "\"", 910, 1);
#line 31 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
WriteAttributeValue("", 890, Model.Cliente.Email, 890, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(911, 212, true);
                WriteLiteral(" name=\"cliente_email\" />\r\n        </div>\r\n\r\n        <br />\r\n\r\n        <div>\r\n                <label for=\"telefone\"><i>Telefone</i></label>\r\n                <br />\r\n                <input id=\"telefone\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value =\"", 1123, "\"", 1155, 1);
#line 39 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
WriteAttributeValue("", 1132, Model.Cliente.Telefone, 1132, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1156, 916, true);
                WriteLiteral(@" name=""cliente_telefone"" />
        </div>

        <br />

    <div class=""calendário"">
    <p><i>Ecolha o dia e a hora:</i></p>
    <img src=""/img/calendário1.jpg"" style=""width: 10em"" alt=""calendário"" title=""calendário""/>
    </div>

        <br />

            <div>
                <label for=""data""><i>Dia:</i></label>
                <br />
                <input id=""data"" type=""date"" maxlength=""20"" minlength=""3"" name=""data"" />
            </div>

            <br />

            <div>
                <label for=""hora""><i>Hora:</i></label>
                <br />
                <input id=""hora"" type=""time"" maxlength=""20"" minlength=""3"" name=""hora"" />
            </div>

            <br />

            <div>
                <label for=""tipoEvento""><i>Tipo de evento:</i></label> <br />
                <select id=""tipoEvento"" name=""tipoEvento"" required>
                    ");
                EndContext();
                BeginContext(2072, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07c49014130c53189773bd29a716e608653db14a8377", async() => {
                    BeginContext(2107, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2125, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 71 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                     foreach (var tipoEvento in Model.TipoEvento)
                    {

#line default
#line hidden
                BeginContext(2217, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2241, 134, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07c49014130c53189773bd29a716e608653db14a10862", async() => {
                    BeginContext(2273, 15, false);
#line 73 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                                                  Write(tipoEvento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2288, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2294, 16, false);
#line 73 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                                                                       Write(tipoEvento.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(2310, 56, true);
                    WriteLiteral("\r\n                            \r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                          WriteLiteral(tipoEvento.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2375, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 76 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                    }

#line default
#line hidden
                BeginContext(2400, 543, true);
                WriteLiteral(@"                </select>
            </div>

            <br />

            <div>
                <label for=""descricao""><i>Descrição do evento:</i></label>
                <br />
                <textarea name=""descricao"" id=""descricao"" cols=""10"" rows=""3""></textarea>
            </div>

            <br />

        <div class=""servicosAdicionais"">
            <label for=""tipoEvento""><i>Serviços Adicionais:</i></label> <br />
        <select id=""servicosAdicionais"" name=""servicosAdicionais"" required>
                    ");
                EndContext();
                BeginContext(2943, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07c49014130c53189773bd29a716e608653db14a14439", async() => {
                    BeginContext(2978, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2996, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 94 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                     foreach (var servicosAdicionais in Model.ServicosAdicionais)
                    {

#line default
#line hidden
                BeginContext(3104, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3128, 158, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07c49014130c53189773bd29a716e608653db14a16941", async() => {
                    BeginContext(3168, 23, false);
#line 96 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                                                          Write(servicosAdicionais.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(3191, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(3197, 24, false);
#line 96 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                                                                                       Write(servicosAdicionais.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(3221, 56, true);
                    WriteLiteral("\r\n                            \r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 96 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                          WriteLiteral(servicosAdicionais.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3286, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 99 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                    }

#line default
#line hidden
                BeginContext(3311, 552, true);
                WriteLiteral(@"                </select>
        </div>

        <br />

        <input type=""submit"" value=""Finalizar cadastro do evento"" />
        <h3>Histórico de eventos</h3>

        <table>
            <thead>
                <tr>
                    <th>Dia</th>
                    <th>Hora</th>
                    <th>Tipo de evento</th>
                    <th>Descrição</th>
                    <th>Serviço adicional</th>
                    <th>Preço</th>
                </tr>
            </thead>
            
            <tbody>
");
                EndContext();
#line 121 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                 foreach( var evento in Model.Evento) {

#line default
#line hidden
                BeginContext(3920, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(3975, 24, false);
#line 123 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                       Write(evento.DataDoEvento.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(3999, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(4035, 16, false);
#line 124 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                       Write(evento.Hora.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(4051, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(4087, 22, false);
#line 125 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                       Write(evento.TipoEvento.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(4109, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(4145, 21, false);
#line 126 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                       Write(evento.Descricao.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(4166, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(4202, 30, false);
#line 127 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                       Write(evento.ServicosAdicionais.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(4232, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(4268, 17, false);
#line 128 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                       Write(evento.PrecoTotal);

#line default
#line hidden
                EndContext();
                BeginContext(4285, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 130 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
                }

#line default
#line hidden
                BeginContext(4338, 58, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n        \r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 19 "C:\Users\Laric\OneDrive\Documentos\SENAI\1ºTermo\MVC's\RoleTopMVC\Views\CadastroEvento\Evento.cshtml"
AddHtmlAttributeValue("", 457, Url.Action("Registrar", "CadastroEvento"), 457, 42, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4403, 9, true);
            WriteLiteral("\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.CadastroEventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
