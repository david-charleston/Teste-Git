using System;

namespace ExemploDateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTimeKind.Local é o horário que está na maquina
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            // DateTimeKind.Utc é o horário de Greenwich    
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d1.Kind: {d1.Kind}");
            Console.WriteLine($"d1 to local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to utc: {d1.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d2.Kind: {d2.Kind}");
            Console.WriteLine($"d2 to local: {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to utc: {d2.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine("ISO 8601");
            DateTime d3 = DateTime.Parse("2000-08-15 13:05:58");
            // Padrão ISO 8601
            DateTime d4 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para encerrar o programa...");
            Console.ReadKey();


        }
    }
}
