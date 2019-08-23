using System;

namespace ExIComparable
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1]);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {string.Format("{0:c2}", Salary)}";
        }

        // O método vai comparar os funcionários pelo nome
        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not Employee");
            }
            // Armazena o funcionário em uma variável temporaria
            Employee other = obj as Employee;
            // Returna o nome
            return Name.CompareTo(other.Name);
        }
    }
}
