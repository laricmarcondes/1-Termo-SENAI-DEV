using System;

namespace Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor da variável A: ");
            double varA = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da variável B: ");
            double varB = double.Parse(Console.ReadLine());

            double var1 = varB;
            double var2 = varA;

            System.Console.WriteLine("A primeira variável é: " + var1);
            System.Console.WriteLine("A segunda variável é: " + var2);
        }
    }
}
