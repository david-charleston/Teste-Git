using System;

namespace ExFicacaoHeranca.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (Used) {string.Format("{0:c2}", Price)} " +
                $"(Manufactured date: {ManufactureDate.ToShortDateString()})";
        }
    }
}
