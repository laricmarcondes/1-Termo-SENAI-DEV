using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class DesodoranteAerosol : Lixo, IDescarteEspecial
    {
        public string DescarteEspecial()
        {
            return this.GetType().Name;;
        }
    }
}