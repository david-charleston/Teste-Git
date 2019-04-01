using System;
using System.Collections.Generic;

namespace ExFicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando o HashSet
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();
            int n = 0;

            Console.WriteLine("O curso A possui quantos alunos?");
            Console.Write("Digite os códigos dos alunos: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                cursoA.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("O curso B possui quantos alunos?");
            Console.Write("Digite os códigos dos alunos: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                cursoB.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("O curso C possui quantos alunos?");
            Console.Write("Digite os códigos dos alunos: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                cursoC.Add(Convert.ToInt32(Console.ReadLine()));
            }

            HashSet<int> Total = new HashSet<int>();
            Total.UnionWith(cursoA);
            Total.UnionWith(cursoB);
            Total.UnionWith(cursoC);

            Console.WriteLine();
            Console.WriteLine("O total de alunos: " + Total.Count);

            Console.ReadLine();
        }
    }
}
