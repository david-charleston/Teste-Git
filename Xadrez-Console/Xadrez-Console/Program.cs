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
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
        }
    }
}
