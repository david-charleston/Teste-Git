using System;
using System.Collections.Generic;
using System.Text;

namespace ExecicioClasseAbstrata.Entities
{
    class IndividualPerson : Person
    {
        public double HealthSpending { get; private set; }

        public IndividualPerson(string name, double annualIncome, double healthSpending)
            : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double CalcTax()
        {
            double tax = 0;

            if (AnnualIncome < 20000)
            {
                tax = (AnnualIncome * 0.15) - (HealthSpending * 0.5);
            }
            else if (AnnualIncome >= 20000)
            {
                tax = (AnnualIncome * 0.25) - (HealthSpending * 0.5);
            }
            return tax;
        }
    }
}
