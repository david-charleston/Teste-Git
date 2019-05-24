using System;
using System.IO;

namespace FileStreamEStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trabalhando com FileStream e StreamReader
            string path = @"C:\Users\davir\Desktop\File.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                fileStream = new FileStream(path, FileMode.Open);
                streamReader = new StreamReader(fileStream);

                // Lê apenas uma linha do arquivo
                string line = streamReader.ReadToEnd();

                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}
