namespace ExFicacaoHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} {string.Format("{0:c2}", TotalPrice())} " +
                $"(Customs Fee: {string.Format("{0:c2}", CustomsFee)})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
