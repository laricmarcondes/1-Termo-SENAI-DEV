using System.Collections.Generic; 

namespace Reciclagem.Models
{
    public class Lixeira
    {
        public static Dictionary<int, Lixo> lixos = new Dictionary<int, Lixo> {
            {1, new DesodoranteAerosol()},
            {2, new GarrafaDeVidro()},
            {3, new GarrafaPet()},
            {4, new Latinha()},
            {5, new Papelao()},
            {6, new SementesDeFrutas()},
        };
    }
}