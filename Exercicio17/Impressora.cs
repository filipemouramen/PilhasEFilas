using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{    
class Documento
    {
        public string Nome { get; set; }
        public string Prioridade { get; set; } 

        public Documento(string nome, string prioridade)
        {
            Nome = nome;
            Prioridade = prioridade.ToLower();
        }
    }

    class GerenciadorImpressao
    {
        private Queue<Documento> filaAltaPrioridade = new Queue<Documento>();
        private Queue<Documento> filaBaixaPrioridade = new Queue<Documento>();

        public void AdicionarDocumento(Documento doc)
        {
            if (doc.Prioridade == "alta")
            {
                filaAltaPrioridade.Enqueue(doc);
            }
            else
            {
                filaBaixaPrioridade.Enqueue(doc);
            }

            Console.WriteLine($"Documento {doc.Nome} com prioridade {doc.Prioridade} adicionado à fila.");
        }

        public void ImprimirProximo()
        {
            if (filaAltaPrioridade.Count > 0)
            {
                Documento doc = filaAltaPrioridade.Dequeue();
                Console.WriteLine($"Imprimindo (prioridade alta): {doc.Nome}");
            }
            else if (filaBaixaPrioridade.Count > 0)
            {
                Documento doc = filaBaixaPrioridade.Dequeue();
                Console.WriteLine($"Imprimindo (prioridade baixa): {doc.Nome}");
            }
            else
            {
                Console.WriteLine("Nenhum documento na fila.");
            }
        }

        public void MostrarFilas()
        {
            Console.WriteLine("---Fila de Prioridade Alta---");
            foreach (var doc in filaAltaPrioridade)
            {
                Console.WriteLine($"{doc.Nome}");
            }

            Console.WriteLine("---Fila de Prioridade Baixa---");
            foreach (var doc in filaBaixaPrioridade)
            {
                Console.WriteLine($"{doc.Nome}");
            }
        }
    }
}