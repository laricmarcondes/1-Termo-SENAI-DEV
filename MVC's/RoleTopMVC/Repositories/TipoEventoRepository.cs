using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class TipoEventoRepository
    {
        private const string PATH = "Database/TipoEvento.csv";

        public double ObterPrecoDe(string tipoEvento)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(tipoEvento))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<TipoEvento> ObterTodos()
        {
            List<TipoEvento> tipoEvento = new List<TipoEvento>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                TipoEvento t = new TipoEvento();
                string[] dados = linha.Split(";");
                t.Nome = dados[0];
                t.Preco = double.Parse(dados[1]);
                tipoEvento.Add(t);
            }
            return tipoEvento;
        }
    }
}