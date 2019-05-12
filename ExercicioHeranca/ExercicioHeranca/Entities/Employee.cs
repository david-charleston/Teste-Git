namespace ExercicioHeranca.Entities
{
    class Employee
    {
        public string Name { get; private set; }
        public double Hours { get; private set; }
        public double ValuePerHour { get; private set; }

        public Employee(string name, double hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHours;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
