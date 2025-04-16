using Exercicio10;
using System;

class Program
{
    static void Main()
    {
        MinhaPilha<int> pilha = new MinhaPilha<int>();

        pilha.Push(10);
        pilha.Push(20);
        pilha.Push(30);

        Console.WriteLine($"Topo da pilha: {pilha.Peek()}");
        Console.WriteLine($"Tamanho: {pilha.Count}");

        Console.WriteLine($"Removido: {pilha.Pop()}");
        Console.WriteLine($"Novo topo: {pilha.Peek()}");
        Console.WriteLine($"Tamanho: {pilha.Count}");
    }
}