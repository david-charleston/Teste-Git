using System;

namespace OperacosDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;

            Console.WriteLine(d);
            Console.WriteLine($"1)Date: {d.Date}");
            Console.WriteLine($"2)Day: {d.Day}");
            Console.WriteLine($"3)DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4)DayOfYear: {d.DayOfYear} ");
            Console.WriteLine($"5)Hour: {d.Hour}");
            Console.WriteLine($"6)Kind: {d.Kind}");
            Console.WriteLine($"7)Milliseconds: {d.Millisecond}");
            Console.WriteLine($"8)Minute: {d.Minute}");
            Console.WriteLine($"9)Month: {d.Month}");
            Console.WriteLine($"10)Second: {d.Second}");
            Console.WriteLine($"11)Ticks: {d.Ticks}");
            Console.WriteLine($"12)TimeOfYear: {d.TimeOfDay}");
            Console.WriteLine($"13)Year: {d.Year}");

            Console.WriteLine();

            Console.WriteLine("Conversões para string:");
            Console.WriteLine($"ToLongDateString(): {d.ToLongDateString()}");
            Console.WriteLine($"ToLongTimeString(): {d.ToLongTimeString()}");
            Console.WriteLine($"ToShortDateString(): {d.ToShortDateString()}");
            Console.WriteLine($"ToShortTimeString(): {d.ToShortTimeString()}");
            Console.WriteLine($"ToString(): {d.ToString()}");
            // Implementando uma máscara de formatação
            Console.WriteLine($"ToString('yyyy-MM-dd HH:mm:ss'): " +
                $"{d.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine($"ToString('yyyy-MM-dd HH:mm:ss'): " +
                $"{d.ToString("yyyy-MM-dd HH:mm:ss.fff")}");

            Console.WriteLine();

            Console.WriteLine("Operações com DateTime:");
            DateTime d1 = d.AddHours(2);
            DateTime d2 = d.AddMinutes(5);

            Console.WriteLine($"Hora não alterada: {d.ToLongTimeString()}");
            Console.WriteLine($"Hora alterada: {d1.ToLongTimeString()}");
            Console.WriteLine($"Minutos alterados: {d2.ToLongTimeString()}");

            Console.WriteLine();

            Console.WriteLine("Realizando uma subtração de datas:");
            DateTime d3 = new DateTime(2019, 08, 15);

            // Realiza a subtração de datas
            TimeSpan t = d3.Subtract(d);

            Console.WriteLine($"Restam {t.ToString("dd")} dias");

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
