using System;
using System.Collections.Generic;
using System.Text;

namespace ExPredicate.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {string.Format("{0:c2}", Price)}";
        }
    }
}
