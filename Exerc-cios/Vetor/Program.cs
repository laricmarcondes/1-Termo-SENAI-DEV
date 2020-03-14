using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int par = 0;
            int impar = 0;

            for(int cont = 0; cont <=5 ; cont ++){
                Console.Write($"Digite um número: ");
                Console.ReadLine();
                vetor[cont] = int.Parse(Console.ReadLine());
            }    

            foreach(int num in vetor){
                if(num % 2 == 0){
                    par++;
                } else {
                    impar++;
                }
            }

            Console.WriteLine($"Você tem {par} número pares e {impar} números ímpares");

        }
    }
}
