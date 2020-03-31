using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Digite um número para a altura:");
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

