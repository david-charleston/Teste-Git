using System;
using System.IO;
using System.Collections.Generic;

namespace ExIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            // A IComparable é utilizada para comparar objetos
            // Esta interface retorna um número inteiro

            string file = @"C:\Users\davir\Desktop\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    // O método sort ordena uma lista
                    list.Sort();

                    foreach (Employee item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
