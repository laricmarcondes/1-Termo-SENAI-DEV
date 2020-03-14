using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enuns;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroEventoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        CadastroEventoRepository cadastroEventoRepository = new CadastroEventoRepository();

        ServicosAdicionaisRepository servicosAdicionaisRepository = new ServicosAdicionaisRepository();

        TipoEventoRepository tipoEventoRepository = new TipoEventoRepository ();

        public IActionResult Evento()
        {
            CadastroEventoViewModel cadastro = new CadastroEventoViewModel();
            cadastro.ServicosAdicionais = servicosAdicionaisRepository.ObterTodos();
            cadastro.TipoEvento = tipoEventoRepository.ObterTodos();

            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                cadastro.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                cadastro.NomeCliente = nomeUsuario;
            }

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                cadastro.UsuarioNome = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                cadastro.Cliente = clienteLogado;
                cadastro.Evento = cadastroEventoRepository.ObterTodosPorCliente(emailCliente);

            }

            cadastro.NomeView = "CadastroEvento";
            cadastro.UsuarioEmail = emailCliente;
            cadastro.UsuarioNome = nomeUsuario;

            return View (cadastro);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Evento";
            Evento cadastro = new Evento();

            var nomeServicosAdicionais = form["servicosAdicionais"];
            ServicosAdicionais servicosAdicionais = new ServicosAdicionais (nomeServicosAdicionais, servicosAdicionaisRepository.ObterPrecoDe(nomeServicosAdicionais));
            cadastro.ServicosAdicionais = servicosAdicionais;
            
            var nomeTipoEvento = form["tipoEvento"];
            TipoEvento tipoEvento = new TipoEvento (nomeTipoEvento, tipoEventoRepository.ObterPrecoDe(nomeTipoEvento));
            cadastro.TipoEvento = tipoEvento;

            var nomeDataDoEvento = form["data"];
            DataDoEvento dataDoEvento = new DataDoEvento (nomeDataDoEvento);
            cadastro.DataDoEvento = dataDoEvento;

            var Hora = form["hora"];
            Hora hora = new Hora (Hora);
            cadastro.Hora = hora;

            var Descricao = form["descricao"];
            Descricao descricao = new Descricao (Descricao);
            cadastro.Descricao = descricao;
            
            Cliente cliente = new Cliente(){
            Nome = form["cliente_nome"],
            Telefone = form["cliente_telefone"],
            Email = form["cliente_email"]
            };

            cadastro.Cliente = cliente;

            cadastro.DataDoEvento = dataDoEvento;

            cadastro.Data = DateTime.Now;

            cadastro.PrecoTotal = tipoEvento.Preco + servicosAdicionais.Preco;

            if(cadastroEventoRepository.Inserir(cadastro))
            {
                return View("Sucesso", new RespostaViewModel(){
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                return View("Erro");
            }
        }

        public IActionResult Aprovar (ulong id)
        {
            var cadastro = cadastroEventoRepository.ObterPor(id);
            cadastro.Status = (uint) StatusCadastro.APROVADO;

            if (cadastroEventoRepository.Atualizar(cadastro))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este cadastro de evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Reprovar(ulong id)
        {
            var cadastro = cadastroEventoRepository.ObterPor(id);
            cadastro.Status = (uint)StatusCadastro.REPROVADO;

            if(cadastroEventoRepository.Atualizar(cadastro))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

    }
}