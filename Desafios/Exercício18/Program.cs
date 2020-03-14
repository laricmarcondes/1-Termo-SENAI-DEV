using System;

namespace Exercício18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSuperior;

            System.Console.WriteLine("Digite o número: ");
            numeroSuperior = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Limite superior" + numeroSuperior);

            for (int i = 1; i <= numeroSuperior; i += 2){
                Console.Write(i + " ");
            }
        }
    }
}
