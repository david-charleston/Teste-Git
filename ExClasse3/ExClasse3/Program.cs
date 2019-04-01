using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sem o uso de orientação a objeto
            float a, b, c, d, e, f, pX, pY,areaX, areaY;

            Console.WriteLine("Informe os lados do triâgulo X: ");
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());
            pX = (a + b + c) / 2;
            areaX = Convert.ToSingle(Math.Sqrt(pX * (pX - a) * (pX - b) * (pX - c)));

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Informe os lados do triângulo Y: ");
            d = Convert.ToSingle(Console.ReadLine());
            e = Convert.ToSingle(Console.ReadLine());
            f = Convert.ToSingle(Console.ReadLine());
            pY = (d + e + f) / 2;
            areaY = Convert.ToSingle(Math.Sqrt(pY * (pY - d) * (pY - e) * (pY - f)));

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Área do triângulo X: {areaX.ToString("F2")}");
            Console.WriteLine($"Área do triângulo Y: {areaY.ToString("F2")}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
