using System;
using System.Collections.Generic;
using ClasseAbstrata.Entities;
using ClasseAbstrata.Entities.Enums;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            // Criando a lista de Shape
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectange or circle (r/c)? ");
                char d = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (d == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(height, width, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(radius, color));
                }
                Console.WriteLine();
            }

            Console.WriteLine("Shapes areas:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
