using System;
using System.Collections.Generic;

namespace OperacoesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contém o valor máximo que um TimeSpan armazena
            TimeSpan t1 = TimeSpan.MaxValue;
            // Contém o valor minímo que um TimeSpan armazena
            TimeSpan t2 = TimeSpan.MinValue;
            // Contém o valor zero de um TimeSpan
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine($"MaxValue: {t1}");
            Console.WriteLine($"MinValue: {t2}");
            Console.WriteLine($"Zero: {t3}");

            Console.WriteLine();

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            //Essas propriedades retornam um número inteiro
            Console.WriteLine($"Days: {t4.Days}");
            Console.WriteLine($"Hours: {t4.Hours}");
            Console.WriteLine($"Minutes: {t4.Minutes}");
            Console.WriteLine($"Seconds: {t4.Seconds}");
            Console.WriteLine($"Miliseconds: {t4.Milliseconds}");

            Console.WriteLine($"TotalDays: {t4.TotalDays}");
            Console.WriteLine($"TotalHours: {t4.TotalHours}");
            Console.WriteLine($"TotalMinutes: {t4.TotalMinutes}");
            Console.WriteLine($"TotalSeconds: {t4.TotalSeconds}");
            Console.WriteLine($"TotalMiliseconds: {t4.TotalMilliseconds}");

            Console.WriteLine();

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t5.Add(t6);
            TimeSpan subtract = t5.Subtract(t6);

            Console.WriteLine($"Add(): {sum}");
            Console.WriteLine($"Subtract(): {subtract}");
        }
    }
}
