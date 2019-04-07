using System;

namespace CalcularHorasMinSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoSeg, h, m, s;

            Console.Write("Informe a duração do evento em segundos: ");
            tempoSeg = Convert.ToInt32(Console.ReadLine());
            h = tempoSeg / 3600;
            m = (tempoSeg - (h * 3600));
            s = tempoSeg - (h * 3600) - (m * 60);

            TimeSpan duracao = new TimeSpan(h, m, s);

            Console.WriteLine($"A duração do evento é de {duracao}");

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
    }
}
