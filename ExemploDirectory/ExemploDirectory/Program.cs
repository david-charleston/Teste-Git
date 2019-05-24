using System;
using System.IO;
using System.Collections.Generic;

namespace ExemploDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\davir\Desktop\Pasta_Teste";

            try
            {
                // retorna todas as pastas que existe do diretório de origem
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", 
                    SearchOption.AllDirectories);

                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                Console.WriteLine();

                // retorna todos os arquivos do diretório de origem
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                // Cria uma pasta dentro do diretório
                Directory.CreateDirectory($"{path}\\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
