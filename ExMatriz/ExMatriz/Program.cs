using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo do Professor Nelio
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                // Separando os valores para armazenar em cada posição
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Negative numbers: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write(count);

            Console.WriteLine();
        }
    }
}
