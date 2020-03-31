using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes ()
        {
            Console.WriteLine("Trocando arcodes da guitarra");
            return true;
        }

        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo da guitarra");
            return true;
        }
    }
}