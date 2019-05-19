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
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            tabuleiro.AddPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(0, 0));
            tabuleiro.AddPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(4, 4));


            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadKey();
        }
    }
}
