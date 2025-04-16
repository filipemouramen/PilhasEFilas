using System.Collections;
using System.Collections.Generic;

namespace Filas
{
    internal class program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            Console.WriteLine("Fila está vazia? " + (fila.Count == 0));

            fila.Enqueue("Preechida1");
            fila.Enqueue("Preenchida2");

            Console.WriteLine("Fila está vazia? " + (fila.Count == 0));
        }
    }
}