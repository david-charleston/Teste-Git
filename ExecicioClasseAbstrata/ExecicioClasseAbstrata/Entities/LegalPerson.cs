namespace ExecicioClasseAbstrata.Entities
{
    class LegalPerson : Person
    {
        public int Employees { get; private set; }

        public LegalPerson(string name, double annualIncome, int employees) 
            : base (name, annualIncome)
        {
            Employees = employees;
        }

        public override double CalcTax()
        {
            double tax = 0;

            if (Employees <= 10)
            {
                tax = AnnualIncome * 0.16;
            }
            else if (Employees > 10)
            {
                tax = AnnualIncome * 0.14;
            }
            return tax;
        }
    }
}
