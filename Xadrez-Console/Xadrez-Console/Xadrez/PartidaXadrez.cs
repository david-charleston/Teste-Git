using System;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Enums;

namespace Xadrez_Console.Xadrez
{
    class PartidaXadrez
    {
        private int turno;
        private Cor jodadorAtual;
        public Tabuleiro.Tabuleiro Tabuleiro { get; }
        public bool Terminda { get; private set; }

        public PartidaXadrez()
        {
            Tabuleiro = new Tabuleiro.Tabuleiro(8, 8);
            turno = 1;
            jodadorAtual = Cor.Branca;
            Terminda = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = Tabuleiro.RetirarPeca(origem);
            peca.IncrementarQtdMovimento();
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.AddPeca(peca, destino);
        }

        private void ColocarPecas()
        {
            Tabuleiro.AddPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('c', 1).ToPosicao());
        }
    }
}
