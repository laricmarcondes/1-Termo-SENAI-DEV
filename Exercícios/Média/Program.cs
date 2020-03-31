using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Entre com a 1ª nota:");
            nota1 = double.Parse (Console.ReadLine());
            Console.Write("Entre com a 2ª nota:");
            nota2 = double.Parse (Console.ReadLine());
            Console.Write("Entre com a 3ª nota:");
            nota3 = double.Parse (Console.ReadLine());
            Console.Write("Entre com a 4ª nota:");
            nota4 = double.Parse (Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Sua nota é : " + media);

            if (media >= 7.0) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
