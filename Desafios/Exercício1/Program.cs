using System;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
                    Console.Write("Entre com a base do retângulo: ");
                    double baseRet = double.Parse(Console.ReadLine());
                    Console.Write("Entre com a altura do retângulo: ");
                    double altRet = double.Parse(Console.ReadLine());
                    
                    double perimetroRet = (baseRet * 2 + altRet * 2);
                    Console.WriteLine(" O perímetro do retângulo é: " + perimetroRet);
                    
                    double areaRet = (baseRet * altRet);
                    Console.WriteLine(" A área do retângulo é: " + areaRet);
                    
                    double diagonalRet = ((baseRet * baseRet) + (altRet * altRet)) / 2;
                    Console.WriteLine(" A diagonal do retângulo é: " + diagonalRet);
        }
    }
}
