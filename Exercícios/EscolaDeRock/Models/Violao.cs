using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussao
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do baixo");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de violão");
            return true;
        }
        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo da guitarra");
            return true;
        }
    }
}
