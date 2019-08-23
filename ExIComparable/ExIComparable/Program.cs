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

            string file = @"C:\Users\davir\Desktop";

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    List<string> list = new List<string>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
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
