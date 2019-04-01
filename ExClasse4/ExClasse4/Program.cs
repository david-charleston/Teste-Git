using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando orientação a objeto
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Informe as medidas do triângulo X: ");
            x.A = Convert.ToDouble(Console.ReadLine());
            x.B = Convert.ToDouble(Console.ReadLine());
            x.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Informe as medidas do triângulo Y: ");
            y.A = Convert.ToDouble(Console.ReadLine());
            y.B = Convert.ToDouble(Console.ReadLine());
            y.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();
            Console.WriteLine($"Área de X: {areaX.ToString("F4")}");
            Console.WriteLine($"Área de Y: {areaY.ToString("F4")}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
