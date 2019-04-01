using System;

namespace ExListas
{
    class Employers
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employers(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double RaiseSalary(double percentage)
        {
            return Salary += Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {string.Format("{0:c2}", Salary)}";
        }
    }
}
