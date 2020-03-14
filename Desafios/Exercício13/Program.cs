using System;

namespace Exercício13
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1;
            double lado2;
            double lado3;

            System.Console.WriteLine("Digite o primeiro lado: ");
            lado1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo lado: ");
            lado2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o terceiro lado: ");
            lado3 = double.Parse(Console.ReadLine());

            if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1+lado2))
            {
                System.Console.WriteLine("Estes valores formam um triângulo");
            
                if ((lado1 == lado2) && (lado2 == lado3)) {
                    System.Console.WriteLine("Triângulo equilátero");
                } else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3)) {
                    System.Console.WriteLine("Triângulo isósceles");
                } else {
                    System.Console.WriteLine("Triângulo escaleno");
                } 
            } else {
                System.Console.WriteLine("Estes valores não formam um triângulo");
            }
        }
    }
}
