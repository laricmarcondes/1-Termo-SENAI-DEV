using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enuns;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();

        private CadastroEventoRepository cadastroEventoRepository = new CadastroEventoRepository();

        private ServicosAdicionaisRepository servicosAdicionaisRepository = new ServicosAdicionaisRepository();

        private TipoEventoRepository tipoEventoRepository = new TipoEventoRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel ()
            {
                NomeView = "Login",
                UsuarioEmail= ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("=================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("=================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch (cliente.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());

                            return RedirectToAction("Evento", "CadastroEvento");

                            default:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());

                            return RedirectToAction("Dashboard", "Administrador");
                        }
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("senha incorreta"));
                    }
                }
                else
                {
                    return View ("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }

        public IActionResult Evento()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var eventosCliente = cadastroEventoRepository.ObterTodosPorCliente(emailCliente);
            var servicosAdicionais = servicosAdicionaisRepository.ObterTodos();
            var tipoEvento = tipoEventoRepository.ObterTodos();
            var cliente = clienteRepository.ObterPor(emailCliente);

            return View(new CadastroEventoViewModel(){
                Cliente= cliente,
                Evento = eventosCliente,
                ServicosAdicionais = servicosAdicionais,
                TipoEvento= tipoEvento,
                NomeView = "Evento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });

        }
        public IActionResult LogOff ()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
            
        }
    }
}