using System.Collections;
using System.Collections.Generic;

namespace Pilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> elementos = new Stack<int>();

            Console.WriteLine($"A pilha está vazia: {elementos.Count}");
            Console.WriteLine();

            Console.WriteLine("Digite abaixo 5 números para preencher a pilha!");

            elementos.Push(int.Parse(Console.ReadLine()));

            elementos.Push(int.Parse(Console.ReadLine()));

            elementos.Push(int.Parse(Console.ReadLine()));

            elementos.Push(int.Parse(Console.ReadLine()));

            elementos.Push(int.Parse(Console.ReadLine()));

            Console.WriteLine($"A pilha contém {elementos.Count} números");
        }
    }
}