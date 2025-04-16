using System.Collections;
using System.Collections.Generic;

namespace Filas
{
    internal class program
    {
        static void Main(string[] args)
        {
            Queue<string> nomes = new Queue<string>();
            nomes.Enqueue("Ana");
            nomes.Enqueue("Carlos");
            nomes.Enqueue("Beatriz");
            nomes.Enqueue("Daniel");

            foreach(string i in nomes)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Nomes\n");

            Console.WriteLine($"Primeiro da fila {nomes.Peek()} ");
            Console.WriteLine();

            Console.WriteLine($"O removido(a) foi {nomes.Dequeue()}");
            Console.WriteLine();

            Console.WriteLine($"O novo primeiro é {nomes.Peek()}");
            Console.WriteLine();

            Console.WriteLine("Nova fila:");

            foreach ( string s in nomes.ToArray())
            {
                Console.WriteLine(s);
            }
        }
    }
}