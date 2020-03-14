using System;
using System.Collections.Generic;
using RoleTopMVC.Enuns;

namespace RoleTopMVC.Models
{
    public class Evento
    {
        public ulong Id {get;set;}
        public TipoEvento TipoEvento {get;set;}

        public ServicosAdicionais ServicosAdicionais {get;set;}

        public Cliente Cliente {get;set;}

        public Cliente Email {get;set;}

        public DateTime Data {get;set;}

        public DataDoEvento DataDoEvento {get;set;}

        public uint Status {get;set;}

        public Hora Hora {get;set;}

        public Descricao Descricao {get;set;}

        public string Pagamento {get;set;}

        public double PrecoTotal {get;set;}

        public Evento()
        {
            this.Cliente = new Cliente();
            this.TipoEvento = new TipoEvento();
            this.ServicosAdicionais = new ServicosAdicionais();
            this.DataDoEvento = new DataDoEvento();
            this.Hora = new Hora();
            this.Descricao = new Descricao();
            this.Id = 0;
            this.Status = (uint) StatusCadastro.PENDENTE;
        }
    }
}