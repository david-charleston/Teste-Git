using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
