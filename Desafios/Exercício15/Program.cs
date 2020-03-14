using System;

namespace Exercício15
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;

            System.Console.WriteLine("Digite um número entre 1 e 12: ");
            mes = int.Parse(Console.ReadLine());

            if ( mes == 1){
                System.Console.WriteLine("Janeiro");
            } else if (mes == 2){
                System.Console.WriteLine("Fevereiro");
            } else if (mes == 3){
                System.Console.WriteLine("Março");
            } else if (mes == 4){
                System.Console.WriteLine("Abril");
            } else if (mes == 5){
                System.Console.WriteLine("Maio");
            } else if (mes == 6){
                System.Console.WriteLine("Junho");
            } else if (mes == 7){
                System.Console.WriteLine("Julho");
            } else if (mes == 8){
                System.Console.WriteLine("Agosto");
            } else if (mes == 9){
                System.Console.WriteLine("Setembro");
            } else if (mes == 10){
                System.Console.WriteLine("Outubro");
            } else if (mes == 11){
                System.Console.WriteLine("Novembro");
            } else if (mes == 12){
                System.Console.WriteLine("Dezembro");
            }
        }
        
    }
}
