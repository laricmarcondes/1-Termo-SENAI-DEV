using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class CadastroEventoViewModel : BaseViewModel
    {
        public List<Evento> Evento {get;set;}

        public List<TipoEvento> TipoEvento {get;set;}
        
        public List<ServicosAdicionais> ServicosAdicionais {get;set;}

        public List<Hora> Hora {get;set;}

        public List<DataDoEvento> DataDoEvento {get;set;}

        public List<Descricao> Descricao {get;set;}

        public Cliente Cliente {get; set;}

        public string NomeCliente{get; set;}

        public CadastroEventoViewModel()
        {
            this.Evento = new List<Evento>();
            this.TipoEvento = new List<TipoEvento>();
            this.ServicosAdicionais = new List<ServicosAdicionais>();
            this.Hora = new List<Hora>();
            this.DataDoEvento = new List<DataDoEvento>();
            this.Descricao = new List<Descricao>();
            this.Cliente = new Cliente();
            this.NomeCliente = "fulano";
        }
    }
}