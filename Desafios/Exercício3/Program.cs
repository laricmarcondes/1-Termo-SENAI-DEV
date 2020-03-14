using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia;
            double tempo;
            double velocidade;
            double litrosUsados;

            Console.WriteLine("Digite o tempo gasto na viagem: ");
            tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a velocidade média: ");
            velocidade = double.Parse(Console.ReadLine());

            
            distancia = (tempo * velocidade);
            litrosUsados = (distancia / 12);
            Console.WriteLine(" A quantidade de litros usada foi de: " + litrosUsados);

            
        }
    }
}
