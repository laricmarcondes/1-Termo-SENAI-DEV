using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Manter o ritmo do contrabaixo");
            return true;
        }
        public bool TocarAcordes()
        {
            Console.WriteLine("Trocando arcodes do contrabaixo");
            return true;
        }
    }
}