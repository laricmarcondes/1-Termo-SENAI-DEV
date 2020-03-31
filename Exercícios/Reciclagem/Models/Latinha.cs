using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : Lixo, IMetal
    {
        public string ReciclarMetal()
        {
            return this.GetType().Name;;
        }
    }
}