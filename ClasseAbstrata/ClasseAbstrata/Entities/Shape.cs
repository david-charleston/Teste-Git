using ClasseAbstrata.Entities.Enums;

namespace ClasseAbstrata.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color; 
        }

        // Método abstrato
        public abstract double Area();
    }
}
