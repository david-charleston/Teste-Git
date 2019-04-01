using System;
using System.Collections.Generic;

namespace HashSetEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // O conjunto HashSet não permite elementos repitidos
            // O conjunto HashSet não é indexado
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            // O método Add adiciona elementos no conjunto
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            // O método ExecptWith remove os elementos semelhantes ao outro conjunto.
            // Este método realiza a diferença de conjuntos.
            //A.ExceptWith(B);

            /** 
             * O método UnionWith adiciona todos os elementos que não são repitidos no
             * outro conjunto.
             */
            //A.UnionWith(B);

            // O método IntersctWith adiciona os elementos que são comuns em ambos
            //A.IntersectWith(B);

            // Utiliza-se o laço foreach para percorrer um conjunto HashSet.
            foreach (int item in A)
            {
                Console.WriteLine($"Elemento do Conjunto A: {item}");
            }

            Console.WriteLine();

            foreach (int item in B)
            {
                Console.WriteLine($"Elemento do Conjunto B: {item}");
            }

            Console.WriteLine();

            /*Console.Write("Digite um valor inteiro: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (B.Contains(n))
            {
                Console.WriteLine($"O {n} pertence ao conjunto B.");
                // O método Remove remove o elemento do conjunto
                B.Remove(n);
            }
            else
            {
                Console.WriteLine($"O {n} não pertence ao conjunto B.");
            }

            foreach (int item in B)
            {
                Console.WriteLine($"Elemento do Conjunto B: {item}");
            }*/

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
