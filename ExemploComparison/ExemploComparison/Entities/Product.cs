using System;

namespace ExemploComparison.Entities
{
    class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
       
        public override string ToString()
        {
            return $"Name: {Name} R$ {string.Format("{0:c2}", Price)}";
        }
    }
}
