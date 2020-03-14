using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class CadastroEventoRepository : RepositoryBase
    {
        private const string PATH = "Database/CadastroEvento.csv";

        public CadastroEventoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento cadastro)
        {
            var quantidadeCadastros = File.ReadAllLines(PATH).Length;
            cadastro.Id = (ulong) ++quantidadeCadastros;
            var linha = new string[] { PrepararRegistroCSV(cadastro) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var cadastros = ObterTodos();
            List<Evento> cadastrosCliente = new List<Evento>();
            foreach (var cadastro in cadastros)
            {
                if (cadastro.Cliente.Email.Equals(emailCliente))
                {
                    cadastrosCliente.Add(cadastro);
                }
            }
            return cadastrosCliente;
        }

        public List<Evento> ObterTodos()
        {
            var linhas  = File.ReadLines(PATH);
            List<Evento> cadastros = new List<Evento>();
            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                evento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status_evento", linha));
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                evento.DataDoEvento.Nome = ExtrairValorDoCampo("evento_data", linha);
                evento.Hora.Nome = ExtrairValorDoCampo("evento_hora", linha);
                evento.TipoEvento.Nome = ExtrairValorDoCampo("tipo_nome", linha);
                evento.ServicosAdicionais.Nome = ExtrairValorDoCampo("servico_nome", linha);
                evento.Descricao.Nome = ExtrairValorDoCampo("evento_descricao", linha);
                evento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));

                cadastros.Add(evento);
            }
            return cadastros;
        }

        public Evento ObterPor(ulong id)
        {
            var pedidosTotais = ObterTodos();
            foreach (var cadastro in pedidosTotais)
            {
                if (id.Equals(cadastro.Id))
                {
                    return cadastro;
                }
            }
            return null;
        }

        public bool Atualizar(Evento cadastro)
        {
            var cadastrosTotais = File.ReadAllLines(PATH);
            var cadastroCSV = PrepararRegistroCSV(cadastro);
            var linhaCadastro = -1;
            var resultado = false;

            for(int i = 0; i < cadastrosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", cadastrosTotais[i]));
                if(cadastro.Id.Equals(idConvertido))
                {
                    linhaCadastro = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                cadastrosTotais[linhaCadastro] = cadastroCSV;
                File.WriteAllLines(PATH, cadastrosTotais);
            }
            return resultado;
        }
        private string PrepararRegistroCSV(Evento evento)
        {
            Cliente cliente = evento.Cliente;
            TipoEvento tipoEvento = evento.TipoEvento;
            ServicosAdicionais servicosAdicionais = evento.ServicosAdicionais;

            return $"id={evento.Id};status_evento={evento.Status};cliente_nome={cliente.Nome};cliente_email={cliente.Email};cliente_telefone={cliente.Telefone};evento_data={evento.DataDoEvento.Nome};evento_hora={evento.Hora.Nome};tipo_nome={evento.TipoEvento.Nome};servico_nome={evento.ServicosAdicionais.Nome};evento_descricao={evento.Descricao.Nome};preco_total={evento.PrecoTotal}";
        } 
    }
}
