using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    public class FilaCircular<T>
    {
        private T[] itens;
        private int frente;
        private int tras;
        private int count;
        private int capacidade;

        public FilaCircular(int capacidade)
        {
            this.capacidade = capacidade;
            itens = new T[capacidade];
            frente = 0;
            tras = 0;
            count = 0;
        }

        public int Count => count;
        public bool EstaCheia => count == capacidade;
        public bool EstaVazia => count == 0;

        public void Enqueue(T item)
        {
            if (EstaCheia)
                throw new InvalidOperationException("A fila está cheia.");

            itens[tras] = item;
            tras = (tras + 1) % capacidade;
            count++;
        }

        public T Dequeue()
        {
            if (EstaVazia)
                throw new InvalidOperationException("A fila está vazia.");

            T item = itens[frente];
            frente = (frente + 1) % capacidade;
            count--;
            return item;
        }

        public T Peek()
        {
            if (EstaVazia)
                throw new InvalidOperationException("A fila está vazia.");

            return itens[frente];
        }
    }
}