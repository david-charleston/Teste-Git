using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Posição {i}, {j}: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.WriteLine("Aqui está a sua matriz: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Digite um número que está na matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Posição: " + i + ", " + j);
                    }
                    if (j > 0)
                    {
                        Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Acima: " + mat[i - 1, j]);
                    }
                    if (j < n - 1)
                    {
                        Console.WriteLine("Direita: " + mat[i, j + 1]);
                    }
                    if (i < m - 1)
                    {
                        Console.WriteLine("Baixo: " + mat[i + 1, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
