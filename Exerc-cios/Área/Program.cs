using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma = "";
            do{

            Console.WriteLine("Calcula Area");
            Console.WriteLine("1 - Triangulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Losango");
            Console.WriteLine("4 - Trapezio");
            Console.WriteLine("5 - Retangulo");
            Console.WriteLine("6 - Circulo");
            Console.WriteLine("fim para terminar.");
            Console.Write("Selecione uma forma: ");
            forma = Console.ReadLine();

            switch(forma){
                case "1" :
                    Console.WriteLine("Área do Triangulo");
                    Console.Write("Entre com a Base: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.Write("Entre com a Altura: ");
                    double altTri = double.Parse(Console.ReadLine());
                    double areaTri = (baseTri * altTri) / 2;
                    Console.WriteLine(" A área do triangulo é: " + areaTri);
                break;

                case "2" :
                    Console.WriteLine("Área do Quadrado");
                    Console.Write("Qual o lado do quadrado? ");
                    double ladoQuad = double.Parse(Console.ReadLine());
                    double areaQuad = ladoQuad * ladoQuad;
                    Console.WriteLine("A área do quadrado é:" + areaQuad);
                break;
                
                case "3" :
                    Console.WriteLine("Digite a diagonal maior do Losango: ");
                    double dMaior = double.Parse(Console.ReadLine());
                    Console.Write("Digite a diagonal menor do Losango: ");
                    double dMenor = double.Parse(Console.ReadLine());
                    double areaLos = (dMaior * dMenor) / 2;
                    Console.WriteLine("A área do quadrado é:" + areaLos);
                break;

                case "4":
                        Console.Write("Digite a base maior do Trapézio: ");
                        double bMaior = double.Parse(Console.ReadLine());
                        Console.Write("Digite a base menor do Trapézio: ");
                        double bMenor = double.Parse(Console.ReadLine());
                        Console.Write("Qual a altura do Trapézio: ");
                        double hTrap = double.Parse(Console.ReadLine());
                        double areaTrap = ((bMaior + bMenor) * hTrap)/2;
                        Console.WriteLine("A área do Trapézio é " + areaTrap);
                        break;

                case "5":
                        Console.Write("Digite o primeiro lado do Retângulo: ");
                        double l1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo lado do Retângulo: ");
                        double l2 = double.Parse(Console.ReadLine());
                        double areaRet = l1 * l2;
                        Console.WriteLine("A área do Retângulo é " + areaRet);
                break;

                case "6":
                        Console.Write("Qual o raio da circunferência? ");
                        double r = double.Parse(Console.ReadLine());
                        double areaCirc = 3.14 * r * r;
                        Console.WriteLine("A área da Circunferência é " + areaCirc);
                break;
            }
            Console.WriteLine();
        }while(forma != "fim");
    }
}
}


