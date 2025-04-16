using System.Collections;
using System.Collections.Generic;

namespace Pilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numero = new Stack<int>();
            numero.Push(1);
            numero.Push(2);
            numero.Push(3);
            numero.Push(4);
            numero.Push(5);

            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }    
        }
    }
}