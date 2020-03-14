using System;

namespace Exercício19
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int [5];

            for(int x = 0; x < 5; x++)
            {
                Console.Write($"{x}: ");
                vetor[x] = int.Parse (Console.ReadLine());
            }

            for(int y = 0; y < 5; y++)
            {
                Console.Write($"{y}");
            }
        }
    }
}
