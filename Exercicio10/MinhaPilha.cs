using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    public class MinhaPilha<T>
    {
        private List<T> itens = new List<T>();

        public int Count => itens.Count;

        public void Push(T item)
        {
            itens.Add(item);
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("A pilha está vazia.");

            T item = itens[Count - 1];
            itens.RemoveAt(Count - 1);
            return item;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("A pilha está vazia.");

            return itens[Count - 1];
        }
    }
}