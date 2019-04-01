using System;
using System.Globalization;

namespace DateTimeExemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 1");
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine(date.Ticks);

            QuebraLinha();

            Console.WriteLine("Exemplo 2");
            Console.WriteLine("Construtores: ");
            DateTime d1 = new DateTime(2019, 3, 17);
            DateTime d2 = new DateTime(2019, 3, 17, 22, 21, 50);
            DateTime d3 = new DateTime(2019, 3, 17, 20, 45, 6, DateTimeKind.Utc);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine();

            Console.WriteLine("Builders: ");
            DateTime d4 = DateTime.Now; // Pega a hora e a data
            DateTime d5 = DateTime.Today; // Pega só a data 
            DateTime d6 = DateTime.UtcNow; // Pega o horário universal
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            QuebraLinha();

            Console.WriteLine("Exemplo 3");
            DateTime d7 = DateTime.Parse("2000-08-19");
            DateTime d8 = DateTime.Parse("2015-05-22 22:45:00");
            DateTime d9 = DateTime.Parse("19/08/2000");
            DateTime d10 = DateTime.Parse("19/08/2000 22:41:45");
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            QuebraLinha();

            Console.WriteLine("Exemplo 4");
            // Converte a data com o formato desejado
            // Esse método requer uma máscara de formatação
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:58:45", "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
        }

        static void QuebraLinha()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
        }
    }
}
