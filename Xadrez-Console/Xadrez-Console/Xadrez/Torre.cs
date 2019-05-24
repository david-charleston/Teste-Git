using System;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Enums;

namespace Xadrez_Console.Xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro.Tabuleiro tabuleiro) : base (cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.RetonaPeca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linha, Tabuleiro.Coluna];

            Posicao posicao = new Posicao(0, 0);

            // Norte
            posicao.DefinirPosicao(posicao.Linha - 1, posicao.Coluna);
            while (PodeMover(posicao) && Tabuleiro.PosicaoValida(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;

                if (Tabuleiro.RetonaPeca(posicao) != null && Tabuleiro.RetonaPeca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Linha--;
            }

            // Sul
            posicao.DefinirPosicao(posicao.Linha + 1, posicao.Coluna);
            while (PodeMover(posicao) && Tabuleiro.PosicaoValida(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;

                if (Tabuleiro.RetonaPeca(posicao) != null && Tabuleiro.RetonaPeca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Linha++;
            }

            // Leste
            posicao.DefinirPosicao(posicao.Linha, posicao.Coluna + 1);
            while (PodeMover(posicao) && Tabuleiro.PosicaoValida(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;

                if (Tabuleiro.RetonaPeca(posicao) != null && Tabuleiro.RetonaPeca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Coluna++;
            }

            // Oeste
            posicao.DefinirPosicao(posicao.Linha, posicao.Coluna - 1);
            while (PodeMover(posicao) && Tabuleiro.PosicaoValida(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;

                if (Tabuleiro.RetirarPeca(posicao) != null && Tabuleiro.RetirarPeca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Coluna--;
            }

            return mat;
        }
    }
}
