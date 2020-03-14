
using System;

namespace Usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            string loginAdm = "admin";
            string senhaAdm = "admin";

            Console.WriteLine("Login:");
            string login = Console.ReadLine();
            Console.WriteLine("Senha:");
            string senha = Console.ReadLine();

            if((login == loginAdm) && senha == senhaAdm) {
                Console.WriteLine("Bem vindo Admin.");
            }else {
                Console.WriteLine("Olá usuário.");
        }
        }
    }
}
