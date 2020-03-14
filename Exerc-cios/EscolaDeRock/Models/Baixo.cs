using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Trocando arcodes do baixo");
            return true;
        }
    }
}