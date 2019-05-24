using System;
using System.IO;

namespace BlockUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\davir\Desktop\File.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.WriteLine($"Conteúdo do arquivo {Path.GetFileName(path)}");
                        Console.WriteLine();

                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
