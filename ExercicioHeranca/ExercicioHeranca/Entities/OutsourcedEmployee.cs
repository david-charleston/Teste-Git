namespace ExercicioHeranca.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee(string name, double hours, double valuePerHours,double additionalCharge) : 
            base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);   
        }
    }
}
