using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;
using Reciclagem.Enums;
using Reciclagem.View;
using System.Linq;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {

                bool querSair = false;
            do
            {
                System.Console.WriteLine("Estas são as coisas descartadas por você até agora:");
                int codigo = MenuUtils<LixosEnum>.ExibirMenuPadrao();
                Reciclar(Lixeira.lixos[codigo]);

            } while (!querSair);
    }

        private static void Reciclar(Lixo lixo)
        {

            Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault();

            if (tipoLixo.Equals(typeof(IPapel)))
            {
                IPapel lixoConvertido = (IPapel)lixo;
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{lixoConvertido.ReciclarPapel()} deve ir para a lixeira Azul");
                Console.ResetColor();

            }
            else if (tipoLixo.Equals(typeof(IMetal)))
            {
                IMetal lixoConvertido = (IMetal)lixo;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.ReciclarMetal()} deve ir para a lixeira Amarela");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IPlastico)))
            {
                IPlastico lixoConvertido = (IPlastico)lixo;
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{lixoConvertido.ReciclarPlastico()} deve ir para a lixeira Vermelha");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IVidro)))
            {
                IVidro lixoConvertido = (IVidro)lixo;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{lixoConvertido.ReciclarVidro()} deve ir para a lixeira Verde");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IOrganico)))
            {
                IOrganico lixoConvertido = (IOrganico)lixo;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.Organico()} deve ir para a Composteira");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IDescarteEspecial)))
            {
                IDescarteEspecial lixoConvertido = (IDescarteEspecial)lixo;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                System.Console.WriteLine($"{lixoConvertido.DescarteEspecial()} deve ir para o descarte especial");
                Console.ResetColor();
            }
            else
            {
                System.Console.WriteLine("Tipo não identificado!");
            }
            System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
            Console.ReadLine();
        }
    }
}