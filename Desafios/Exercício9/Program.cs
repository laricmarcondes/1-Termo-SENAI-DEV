using System;

namespace Exercício9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pplaneta;
            double Pterra;
            double Mercurio = 0.37;
            double Venus = 0.88;
            double Marte = 0.38;
            double Jupiter = 2.64;
            double Saturno = 1.15;
            double Urano = 1.17;

            string planeta;
            System.Console.WriteLine("|   | Gravidade Relaviva | Planeta |");
            System.Console.WriteLine("|---|--------------------|---------|");
            System.Console.WriteLine("| 1 |        0,37        |Mercúrio |");
            System.Console.WriteLine("| 2 |        0,88        |  Vênus  |");
            System.Console.WriteLine("| 3 |        0,38        |  Marte  | ");
            System.Console.WriteLine("| 4 |        2,64        | Júpiter |");
            System.Console.WriteLine("| 5 |        1,15        | Saturno |");
            System.Console.WriteLine("| 6 |        1,17        |  Urano  |");
            System.Console.Write("Selecione um planeta: ");
            planeta = Console.ReadLine();

            switch(planeta){
                case "1" :
                    System.Console.WriteLine("Digite o peso na Terra:  ");
                    Pterra = double .Parse(Console.ReadLine());
                    Pplaneta= ((Pterra / 10) * Mercurio);
                    System.Console.WriteLine("O peso neste planeta será: " + Pplaneta);
                break;
                case "2" :
                    System.Console.WriteLine("Digite o peso na Terra:  ");
                    Pterra = double .Parse(Console.ReadLine());
                    Pplaneta= ((Pterra / 10) * Venus);
                    System.Console.WriteLine("O peso neste planeta será: " + Pplaneta);
                break;
                case "3" :
                    System.Console.WriteLine("Digite o peso na Terra:  ");
                    Pterra = double .Parse(Console.ReadLine());
                    Pplaneta= ((Pterra / 10) * Marte);
                    System.Console.WriteLine("O peso neste planeta será: " + Pplaneta);
                break;
                case "4" :
                    System.Console.WriteLine("Digite o peso na Terra:  ");
                    Pterra = double .Parse(Console.ReadLine());
                    Pplaneta= ((Pterra / 10) * Jupiter);
                    System.Console.WriteLine("O peso neste planeta será: " + Pplaneta);
                break;
                case "5" :
                    System.Console.WriteLine("Digite o peso na Terra:  ");
                    Pterra = double .Parse(Console.ReadLine());
                    Pplaneta= ((Pterra / 10) * Saturno);
                    System.Console.WriteLine("O peso neste planeta será: " + Pplaneta);
                break;
                case "6" :
                    System.Console.WriteLine("Digite o peso na Terra:  ");
                    Pterra = double .Parse(Console.ReadLine());
                    Pplaneta= ((Pterra / 10) * Urano);
                    System.Console.WriteLine("O peso neste planeta será: " + Pplaneta);
                break;
                }
        }
    }
}
