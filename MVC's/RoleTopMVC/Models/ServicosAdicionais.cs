namespace RoleTopMVC.Models
{
    public class ServicosAdicionais : AdicionalETipo
    {
        public ServicosAdicionais ()
        {

        }

        public ServicosAdicionais (string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}