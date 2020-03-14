using System;

namespace Exercício12
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [3];

            for (int i = 0; i < numeros.Length; i++)
            {
                System.Console.WriteLine("Insira o número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);
            Console.WriteLine($"Os números em ordem crescente serão : {numeros[0]}, {numeros[1]} e {numeros[2]} ");
        }
    }
}
