using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioo13
{
    class FilaCircular
    {
        private int[] fila;
        private int frente;
        private int tras;
        private int tamanho;
        private int capacidade;

        public FilaCircular(int capacidade)
        {
            this.capacidade = capacidade;
            fila = new int[capacidade];
            frente = -1;
            tras = -1;
            tamanho = 0;
        }

        public bool EstaCheia()
        {
            return tamanho == capacidade;
        }

        public bool EstaVazia()
        {
            return tamanho == 0;
        }

        public void Enfileirar(int valor)
        {
            if (EstaCheia())
            {
                Console.WriteLine("Fila cheia");
                return;
            }

            if (EstaVazia())
            {
                frente = 0;
            }

            tras = (tras + 1) % capacidade;
            fila[tras] = valor;
            tamanho++;
            Console.WriteLine($"Enfileirado: {valor}");
        }

        public void Desenfileirar()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Fila vazia");
                return;
            }

            int valor = fila[frente];
            frente = (frente + 1) % capacidade;
            tamanho--;

            if (tamanho == 0)
            {
                frente = -1;
                tras = -1;
            }

            Console.WriteLine($"Desenfileirado: {valor}");
        }

        public void MostrarFila()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Fila vazia");
                return;
            }

            Console.Write("Fila: ");
            for (int i = 0; i < tamanho; i++)
            {
                int index = (frente + i) % capacidade;
                Console.Write(fila[index] + " ");
            }
            Console.WriteLine();
        }
    }
}