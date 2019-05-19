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
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Coluna; j++)
                {
                    if (tabuleiro.RetornaPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tabuleiro.RetornaPeca(i, j));
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        // Troca as cores das pecas
        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Enums.Cor.Branca)
            {
                Console.Write(peca + " ");
            }
            else
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca + " ");
                Console.ForegroundColor = color;
            }
        }
    }
}
