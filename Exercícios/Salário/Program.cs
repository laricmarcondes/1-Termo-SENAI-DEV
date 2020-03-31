using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal;
            double media;
            double aumento = 0.3;

            Console.Write("Coloque o salário:");
            sal = double.Parse(Console.ReadLine());

            media = (sal * aumento) + sal;

            if (sal < 500) {
                Console.WriteLine("Salário atual :" + media);
            } else if (sal > 500) {
                Console.WriteLine("Seu salário continua sendo :" + sal);
            }
        }
    }
}
