using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Lista vazia
            List<string> list = new List<string>();
            // Lista instânciada com valores
            List<string> list1 = new List<string>() { "Maria", "Alex", "Bob" };
            */

            List<string> list = new List<string>();
            
            // O método Add adiciona o elemento no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ann");
            list.Add("Bob");
            // O método Insert adiciona o elemento na index especificado
            list.Insert(0, "David");
            list.Insert(1, "Maria");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"O tamanho da lista: {list.Count}");
            // Foi utilizado um lambda no exemplo abaixo
            // O exemplo abaixo retorna um valor da lista que começa com a letra A
            Console.WriteLine("Encontrando o primeiro resultado que começa com a 'A': " +
                $"{list.Find(x => x[0] == 'A')}");
            Console.WriteLine("Encontrando o último resultado que começa com a 'A': " +
                $"{list.FindLast(x => x[0] == 'A')}");
            Console.WriteLine("Encontrando o primeiro index que satisfaça o predicado: " +
                list.FindIndex(x => x[0] == 'A'));
            Console.WriteLine("Encontrando o último index que satisfaça o predicado: " +
                list.FindLastIndex(x => x[0] == 'A'));
            /*
             * O Predicado é uma função que recebe um valor e retorna verdadeiro ou falso
             * conforme a lógica implementada nessa função
             */

            Console.WriteLine();

            Console.WriteLine("Filtrando os nomes com que contém 5 letras");
            List<string> result = list.FindAll(x => x.Length == 5);

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Removendo os elementos da lista");
            // O método Remove remove o primeiro valor que for igual ao valor passado
            list.Remove("Bob");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Removendo todas as Marias: ");
            // O método RemoveAll remove todos os elementos que forem igual ao parâmetro
            list.RemoveAll(x => x == "Maria");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Removendo pelo index");
            list.RemoveAt(0);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
