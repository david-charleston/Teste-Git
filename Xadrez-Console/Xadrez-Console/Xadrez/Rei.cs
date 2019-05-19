using System;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Enums;

namespace Xadrez_Console.Xadrez
{
    class Rei : Peca
    {
        public Rei (Cor cor, Tabuleiro.Tabuleiro tabuleiro) : base (cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
