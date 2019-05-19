using System;
using Xadrez_Console.Tabuleiro.Exceptions;

namespace Xadrez_Console.Tabuleiro
{
    class Tabuleiro
    {
        private Peca[,] pecas;
        public int Linha { get; private set; }
        public int Coluna { get; private set; }

        public Tabuleiro(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            pecas = new Peca[linha, coluna]; 
        }

        public Peca RetornaPeca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca RetonaPeca(Posicao posicao)
        {
            return pecas[posicao.Linha, posicao.Coluna];
        }

        public void AddPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        // Verifica se há uma peça na posição escolhida
        public bool ExistePeca(Posicao posicao)
        {
            ValidaPosicao(posicao);
            return RetonaPeca(posicao) != null;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha >= Linha || posicao.Coluna < 0 || posicao.Coluna >= Coluna)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidaPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
