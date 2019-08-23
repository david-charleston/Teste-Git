using System;
using System.IO;
using ExercicioManipulacaoArquivo.Entities;

namespace ExercicioManipulacaoArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o caminho do arquivo: ");
                string path = Console.ReadLine();

                // Lê as linhas do arquivo
                string[] lines = File.ReadAllLines(path);

                string directoryPath = Path.GetDirectoryName(path);
                string summaryFolder = $"{path}\\out";
                string summaryFile = $"{summaryFolder}\\summary.csv";

                // Criando o diretório
                Directory.CreateDirectory(directoryPath);

                using (StreamWriter sw = File.AppendText(summaryFile))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");

                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        short quantity = short.Parse(fields[2]);

                        // Instânciando o objeto
                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product.Name + ", " + string.Format("{0:c2}", product.Total()));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
