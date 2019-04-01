using System;

namespace TimeSpanExemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 1");
            TimeSpan t1 = new TimeSpan();
            // Essa é a quantidades de Tick
            TimeSpan t2 = new TimeSpan(900000000);
            TimeSpan t3 = new TimeSpan(2, 11, 15);
            TimeSpan t4 = new TimeSpan(1, 22, 45, 28);
            TimeSpan t5 = new TimeSpan(1, 22, 45, 28, 99);

            Console.WriteLine($"Sem parâmetros: {t1}");
            Console.WriteLine($"Com um parâmetro: {t2}");
            Console.WriteLine($"Com três parâmetros: {t3}");
            Console.WriteLine($"Com quatro parâmetros: {t4}");
            Console.WriteLine($"Com cinco parâmetros: {t5}");

            Console.WriteLine();

            Console.WriteLine("Exemplo 2");
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000);

            Console.WriteLine($"TimeSpan.FromDays(1.5): {t6}");
            Console.WriteLine($"TimeSpan.FromHours(1.5): {t7}");
            Console.WriteLine($"TimeSpan.FromMinutes(1.5): {t8}");
            Console.WriteLine($"TimeSpan.FromSeconds(1.5): {t9}");
            Console.WriteLine($"TimeSpan.FromMilliseconds(1.5): {t10}");
            Console.WriteLine($"TimeSpan.FromTicks(900000000): {t11}");
        }
    }
}
