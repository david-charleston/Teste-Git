using System;
using Xadrez_Console.Enums;

namespace Xadrez_Console.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; protected set; }
        public Cor Cor { get;  protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            QtdMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
