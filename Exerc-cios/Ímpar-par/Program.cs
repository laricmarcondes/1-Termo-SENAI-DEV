using System;

namespace Aplicação
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

        while(num != 0){
            Console.WriteLine("Digite um número ou zero para parar:");
            num = int.Parse (Console.ReadLine());

            if ((num % 2) != 0){
                Console.WriteLine("O número é impar");
            } else {
                Console.WriteLine("O número é par");
            }
        }
        }
    }
}
