using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;

            Console.Write("Digite o tamanho da sua matriz: ");
            int n = int.Parse(Console.ReadLine());

            mat = new int[n, n];

            Console.WriteLine("Agora digite os valores das linhas: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Posição {i}, {j}: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz principal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + "  ");
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Números negativos: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.Write(mat[i, j] + "  ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
