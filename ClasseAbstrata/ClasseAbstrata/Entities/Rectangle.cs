using System;
using ClasseAbstrata.Entities.Enums;

namespace ClasseAbstrata.Entities
{
    class Rectangle : Shape
    {
        public double Height { get; private set; }
        public double Width { get; private set; }

        public Rectangle(double height, double width, Color color) : base(color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
