using System;
using Xadrez_Console.Xadrez;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Tabuleiro.Exceptions;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.Terminda)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicao().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicao().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
