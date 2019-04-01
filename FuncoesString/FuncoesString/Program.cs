using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FHIJ ABC abc DEFG    ";

            string upper = original.ToUpper();
            string lower = original.ToLower();
            string trim = original.Trim();
            // Retorna o indice do primeiro valor correspondente
            int indexOf = original.IndexOf("c");
            int lastIndexOf = original.LastIndexOf("c");
            // "Recortando" uma string
            string substring = original.Substring(3);
            string subtring1 = original.Substring(3, 4);
            // Substituindo os valores dentro de uma string
            string replaceChar = original.Replace('a', 'x');
            string replaceString = original.Replace("abc", "xyz");
            // Verifica se a string é nula ou vazia
            bool nullOrEmpty = String.IsNullOrEmpty(original);


            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToUpper: -{upper}-");
            Console.WriteLine($"ToLower: -{lower}-");
            Console.WriteLine($"Trim: -{trim}-");
            Console.WriteLine($"IndexOf('c'): {indexOf}");
            Console.WriteLine($"LastIndexOf('c'): {lastIndexOf}");
            Console.WriteLine($"Substring(Posição de início: 3): -{substring}-");
            Console.WriteLine($"Substring(3,4): -{subtring1}-");
            Console.WriteLine($"Replace: -{replaceChar}-");
            Console.WriteLine($"Another Replace: -{replaceString}-");
            Console.WriteLine($"IsNullOrEmpty: {nullOrEmpty}");
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
