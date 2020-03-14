using System;

namespace Exercício8
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            
            Console.WriteLine("Digite a altura do triângulo: ");
            altura = int.Parse(Console.ReadLine());

            for(int i = 0; i <=altura; ++i){
                for(int j = altura; j > i; --j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
