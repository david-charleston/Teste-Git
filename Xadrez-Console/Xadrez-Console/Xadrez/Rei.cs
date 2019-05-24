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
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            // Nordeste
            posicao.DefinirPosicao(posicao.Linha - 1, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }
            
            // Leste
            posicao.DefinirPosicao(posicao.Linha, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }
            
            // Sudeste
            posicao.DefinirPosicao(posicao.Linha + 1, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }
            
            // Sul
            posicao.DefinirPosicao(posicao.Linha + 1, posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }
            
            // Sudoeste
            posicao.DefinirPosicao(posicao.Linha + 1, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }
            
            // Oeste
            posicao.DefinirPosicao(posicao.Linha, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }
            
            // Noroeste
            posicao.DefinirPosicao(posicao.Linha - 1, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            return mat;
        }
    }
}
