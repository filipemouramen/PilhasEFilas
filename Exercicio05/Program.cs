using System.Collections;
using System.Collections.Generic;

namespace Pilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> palavraInvertida = new Stack<char>();

            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            foreach (char letra in palavra)
            {
                palavraInvertida.Push(letra);
            }

            Console.WriteLine("Palavra invertida:");

            while(palavraInvertida.Count > 0)
            {
                Console.Write(palavraInvertida.Pop());
            }
        }
    }
}