using System;

namespace Exercício14
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbo;
            
            System.Console.WriteLine("Digite um verbo no infinitivo: ");
            verbo = Console.ReadLine();

            if (verbo.EndsWith("ar")){
                System.Console.WriteLine("Verbo da 1ª conjugação");
            } else if (verbo.EndsWith("er")){
                System.Console.WriteLine("Verdo da 2ª conjugação");
            } else if (verbo.EndsWith("ir")){
                System.Console.WriteLine("Verbo da 3ª conjugação");
            } else {
                System.Console.WriteLine("Verbo não está no infinitivo");
            }
        }
    }
}
