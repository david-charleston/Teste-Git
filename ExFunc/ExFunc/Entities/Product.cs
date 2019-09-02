using System;
using System.Collections.Generic;
using System.Text;

namespace ExFunc.Entities
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
            return $"{Name}, {string.Format("{0:c2}", Price)}";
        }
    }
}
