using System;

namespace ExClasse8
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("1º nota: ");
            aluno.NotaA = Convert.ToDouble(Console.ReadLine());
            Console.Write("2º nota: ");
            aluno.NotaB = Convert.ToDouble(Console.ReadLine());
            Console.Write("3º nota: ");
            aluno.NotaC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Nota final: " + aluno.NotaFinal());

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado!!!");
            }
            else
            {
                Console.WriteLine("Reprovado!!!");
                Console.WriteLine("Faltaram " + aluno.NotaRestante().ToString("F2") + " pontos!!");
            }


            Console.ReadKey();
        }
    }
}
