using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ServicosAdicionaisRepository
    {
        private const string PATH = "Database/ServicosAdicionais.csv";

        public double ObterPrecoDe(string servicosAdicionais)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(servicosAdicionais))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<ServicosAdicionais> ObterTodos()
        {
            List<ServicosAdicionais> servicosAdicionais = new List<ServicosAdicionais>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                ServicosAdicionais a = new ServicosAdicionais();
                string[] dados = linha.Split(";");
                a.Nome = dados[0];
                a.Preco = double.Parse(dados[1]);
                servicosAdicionais.Add(a);
            }
            return servicosAdicionais;
        }
    }
}