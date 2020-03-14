using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            double C;
            double F;

            System.Console.WriteLine("Digite  temperatura em centígrados: ");
            C = double.Parse(Console.ReadLine());

            F = (9 * C + 160) / 5;
            Console.WriteLine(" A temperatura em fahrenheit: " + F);
        }
    }
}
