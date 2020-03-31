using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaDeVidro : Lixo, IVidro
    {
        public string ReciclarVidro()
        {
            return this.GetType().Name;;
        }
    }
}