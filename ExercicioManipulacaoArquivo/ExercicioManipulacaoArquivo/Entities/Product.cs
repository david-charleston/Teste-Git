using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioManipulacaoArquivo.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public short Quantity { get; private set; }

        public Product(string name, double price, short quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Quantity * Price;
        }
    }
}
