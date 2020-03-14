using System;

namespace Exercício16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double peso;
            double altura;
            double imc;

            System.Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            System.Console.WriteLine("Digite o peso em kg: ");
            peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a altura em metros: ");
            altura = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);


            if (imc < 20){
                System.Console.WriteLine(nome + " seu imc é : " + imc);
                System.Console.WriteLine("Abaixo do peso");
            } else if ((imc >= 20) && (imc < 25)){
                System.Console.WriteLine(nome + " seu imc é: " + imc);
                System.Console.WriteLine("Normal");
            } else if ((imc >= 25) && (imc <= 30)){
                System.Console.WriteLine(nome +" seu imc é: " + imc);
                System.Console.WriteLine("Excesso de peso");
            } else if ((imc >= 30) && (imc <= 35)){
                System.Console.WriteLine(nome +" seu imc é :" + imc);
                System.Console.WriteLine("Obesidade");
            } else if (imc > 35){
                System.Console.WriteLine(nome + " seu imc é: " + imc);
                System.Console.WriteLine("Obesidade mórbida");
            }
        }
    }
}
