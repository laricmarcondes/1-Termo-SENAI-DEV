using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPet : Lixo, IPlastico
    {
        public string ReciclarPlastico()
        {
            return this.GetType().Name;
        }
    }
}