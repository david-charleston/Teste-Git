using Utils;

namespace Entities
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
            return $"Pagamento básico: {FormatCurrency.Format(BasicPayment)} \n"
                + $"Taxa: {FormatCurrency.Format(Tax)}\n"
                + $"Total: {FormatCurrency.Format(TotalPayment)}";
        }
    }
}
