using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{

public class MinhaFila<T>
    {
        private T[] itens;
        private int inicio;
        private int fim;
        private int count;

        public MinhaFila(int capacidade = 4)
        {
            itens = new T[capacidade];
            inicio = 0;
            fim = 0;
            count = 0;
        }

        public int Count => count;

        public void Enqueue(T item)
        {
            if (count == itens.Length)
                Redimensionar();

            itens[fim] = item;
            fim = (fim + 1) % itens.Length;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("A fila está vazia.");

            T item = itens[inicio];
            inicio = (inicio + 1) % itens.Length;
            count--;
            return item;
        }

        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("A fila está vazia.");

            return itens[inicio];
        }
        private void Redimensionar()
        {
            T[] novoArray = new T[itens.Length * 2];
            for (int i = 0; i < count; i++)
            {
                novoArray[i] = itens[(inicio + i) % itens.Length];
            }

            itens = novoArray;
            inicio = 0;
            fim = count;
        }
    }
}