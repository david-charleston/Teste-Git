using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linha; i++)
            {
                for (int j = 0; j < tabuleiro.Coluna; j++)
                {
                    if (tabuleiro.RetornaPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.RetornaPeca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
