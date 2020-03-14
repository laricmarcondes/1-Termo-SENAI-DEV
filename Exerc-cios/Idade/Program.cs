using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            int idade = 0;

            do{
                Console.WriteLine("Digite o ano que você nasceu:");
                ano = int.Parse (Console.ReadLine());
                if((ano > 2021) || (ano < 0)){
                    Console.WriteLine("Data inválida");
                }
            } while((ano > 2021) || (ano <0));

            idade = 2019 - ano;

            if(idade < 3) {
                Console.WriteLine("Recém-Nascido");
            }else if ((idade > 3) && (idade <= 11)) {
                Console.WriteLine("Criança");
            }else if ((idade >= 12) && (idade <=19)) {
                Console.WriteLine("Adoloscente");
            }else if ((idade >= 20) && (idade <=65)) {
                Console.WriteLine("Adulto");
            }else if (idade > 65) {
                Console.WriteLine("Idoso");
            }
        }
    }
}
