namespace ExecicioClasseAbstrata.Entities
{
    abstract class Person
    {
        public string Name { get; private set; }
        public double AnnualIncome { get; set; }

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double CalcTax();
    }
}
