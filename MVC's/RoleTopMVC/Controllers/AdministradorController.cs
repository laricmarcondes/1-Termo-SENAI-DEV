using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enuns;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        CadastroEventoRepository cadastroEventoRepository = new CadastroEventoRepository();

        public IActionResult Dashboard()
        {
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if(!ninguemLogado && (uint)TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {
                var cadastros = cadastroEventoRepository.ObterTodos();
                DashboardViewModel dashboardViewModel = new DashboardViewModel();

                foreach (var cadastro in cadastros)
                {
                    switch (cadastro.Status)
                    {
                        case (uint) StatusCadastro.APROVADO:
                            dashboardViewModel.EventosAprovados++;
                        break;
                        case (uint) StatusCadastro.REPROVADO:
                            dashboardViewModel.EventosReprovados++;
                        break;
                        default:
                            dashboardViewModel.EventosPendentes++;
                            dashboardViewModel.Eventos.Add(cadastro);
                        break;
                    }
                }
                    dashboardViewModel.NomeView = "Dashboard";
                    dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
                    return View(dashboardViewModel);
            }
            else
            {
                return View("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });
            }
        }
    }
}