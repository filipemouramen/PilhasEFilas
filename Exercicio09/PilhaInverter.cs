using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class PilhaInverter
    {
        public static void InverterFila(Queue<string> fila)
        {
            Stack<string> pilha = new Stack<string>();

            while (fila.Count > 0)
            {
                pilha.Push(fila.Dequeue());
            }

            while (pilha.Count > 0)
            {
                fila.Enqueue(pilha.Pop());
            }
        }
    }
}