namespace ExercicioSemInterface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Pagamento básico: {FormatCurrency(BasicPayment)}\n" +
                $"Taxa: {FormatCurrency(Tax)}\n" +
                $"Total: {FormatCurrency(TotalPayment)}";
        }

        public string FormatCurrency(double value)
        {
            return string.Format("{0:c2}", value);
        }
    }
}
