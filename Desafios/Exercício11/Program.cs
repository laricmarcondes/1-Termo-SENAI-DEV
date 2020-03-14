using System;

namespace Exercício11
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string [2];

            for (int i = 0; i < nomes.Length; i++)
            {
                System.Console.WriteLine("Insira um nome : ");
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);
            Console.WriteLine($"Os nomes em ordem alfabética serão {nomes[0]} e {nomes[1]}");
        }
    }
}
