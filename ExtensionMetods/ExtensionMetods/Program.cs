using System;
using ExtensionMetods.Extensions;

namespace ExtensionMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo 1:");
            DateTime dt = new DateTime(2019, 08, 21, 23, 47, 00);
            // O método ElapsedTime é um método extendido
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();

            Console.WriteLine("Demo 2:");
            string s1 = "Hello there!!!";
            Console.WriteLine(s1.Cut(4));
        }
    }
}
