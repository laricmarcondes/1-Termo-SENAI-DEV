using System;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            System.Console.WriteLine("Digite o número: ");
            num = int.Parse(Console.ReadLine());

            if ((num % 2) != 0)
            {
                System.Console.WriteLine("O número é ímpar");
            } else {
                System.Console.WriteLine("O número é par");
            }
        }
    }
}
