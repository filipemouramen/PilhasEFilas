using System;
using System.Xml;

public class FilaPrioridade
{
    private string[] valores = new string[10];
    private int[] prioridades = new int[10];
    private int count = 0;

    public void Enqueue(string valor, int prioridade)
    {
        if (count >= 10)
        {
            Console.WriteLine("A fila está cheia. Não é possível adicionar mais elementos.");
            return;
        }

        Console.WriteLine($"Adicionando '{valor}' com prioridade {prioridade}.");
        Console.WriteLine();
        valores[count] = valor;
        prioridades[count] = prioridade;
        count++;
    }

    public string Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("A fila está vazia. Nada para remover.");
            return null;
        }

        int maiorIndice = 0;
        for (int i = 1; i < count; i++)
        {
            if (prioridades[i] > prioridades[maiorIndice])
            {
                maiorIndice = i;
            }
        }

        string valorRemovido = valores[maiorIndice];
        Console.WriteLine($"Removendo '{valorRemovido}' com prioridade {prioridades[maiorIndice]}.");
        Console.WriteLine();

        for (int i = maiorIndice; i < count - 1; i++)
        {
            valores[i] = valores[i + 1];
            prioridades[i] = prioridades[i + 1];
        }

        count--;
        return valorRemovido;
    }

    public void MostrarFila()
    {
        if (count == 0)
        {
            Console.WriteLine("Fila vazia.");
            return;
        }

        Console.WriteLine("Fila atual:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($" - {valores[i]} (prioridade {prioridades[i]})");
        }
    }

    public int Count()
    {
        return count;
    }
}