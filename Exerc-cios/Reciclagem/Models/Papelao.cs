using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixo, IPapel
    {
        public string ReciclarPapel()
        {
            return this.GetType().Name;;
        }
    }
}