using System;
using Xadrez_Console.Xadrez;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Enums;
using Xadrez_Console.Tabuleiro.Exceptions;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

                // Adicionando as peças no tabuleiro
                tabuleiro.AddPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(0, 0));
                tabuleiro.AddPeca(new Torre(Cor.Branca, tabuleiro), new Posicao(9, 0));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            
        }
    }
}
