using Exercicio11;
using System;
class Program
{
    static void Main()
    {
        MinhaFila<string> fila = new MinhaFila<string>();

        fila.Enqueue("Cruzeiro");
        fila.Enqueue("Atlético");
        fila.Enqueue("Mengão");

        Console.WriteLine($"Primeiro da fila: {fila.Peek()}");
        Console.WriteLine($"Tamanho: {fila.Count}");
        Console.WriteLine();

        Console.WriteLine($"Removido: {fila.Dequeue()}");
        Console.WriteLine($"Novo primeiro: {fila.Peek()}");
        Console.WriteLine($"Tamanho: {fila.Count}");
        Console.WriteLine();

        Console.WriteLine($"Removido: {fila.Dequeue()}");
        Console.WriteLine($"Novo primeiro: {fila.Peek()}");
        Console.WriteLine($"Tamanho: {fila.Count}");
        Console.WriteLine();

        Console.WriteLine($"Removido: {fila.Dequeue()}");
        Console.WriteLine($"Tamanho: {fila.Count}");
    }
}