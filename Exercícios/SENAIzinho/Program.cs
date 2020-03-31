using System;
using System.Collections.Generic;
using System.IO;

namespace SENAIzinho
{
    class Program
    {   
        static void Main(string[] args)
        {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            int TotalAlunos = 100;
            Aluno[] alunos =  new Aluno[100];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            //bool quersair;
            
        }
        

        public void CadastrarAluno(Aluno[] alunos, int TotalAlunos, int alunosCadastrados)
        {
            if(TotalAlunos < alunosCadastrados)
            {
                Console.WriteLine("Cadastro de Alunos");
                Console.WriteLine();
                Console.WriteLine("Nome;");
                string nome = Console.ReadLine();
                Console.Write("Dt Nascimento: ");
                DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAluno.Nome = nome;
                novoAluno.DataNascimento = dtNascimento;

                int index =0;
                foreach(Aluno aluno in alunos)
                {
                    if (aluno == null)
                    {
                        alunos[index] = novoAluno;
                        break;
                    }
                    index++;
                }
                alunosCadastrados++;
            }
            
        }
        
    }
}
