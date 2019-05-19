using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        // Converte no indíces da matriz    
        public Posicao ToPosicao()  
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            // o "" força a conversão em string
            return "" + Coluna + Linha; 
        }
    }
}
