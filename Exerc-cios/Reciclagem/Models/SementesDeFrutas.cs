using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class SementesDeFrutas : Lixo, IOrganico
    {
        public string Organico()
        {
            return this.GetType().Name;;
        }
    }
}