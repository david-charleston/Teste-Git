namespace Xadrez_Console.Tabuleiro
{
    class Posicao
    {
        public int Linha { get;  set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public void DefinirPosicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = Coluna;
        }

        public override string ToString()
        {
            return $"Posicao: {Linha}, {Coluna}";
        }
    }
}
