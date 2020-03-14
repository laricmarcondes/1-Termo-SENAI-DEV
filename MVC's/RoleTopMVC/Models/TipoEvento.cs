namespace RoleTopMVC.Models
{
    public class TipoEvento : AdicionalETipo
    {
        public TipoEvento()
        {

        }

        public TipoEvento(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}