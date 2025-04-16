using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main()
    {
        Queue<string> filaclientes = new Queue<string>();

        Console.WriteLine("Digite o número de clientes que irá atender:");
        int quantidade = int.Parse(Console.ReadLine());

        int[] nomes = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Digite o nome do cliente {i + 1} (ou digite 'fim' para terminar)");
            string nome = Console.ReadLine();
            if (nome.Equals("fim", StringComparison.CurrentCultureIgnoreCase))
                break;

            filaclientes.Enqueue(nome);
        }

        Console.WriteLine();

        while (filaclientes.Count > 0)
        {
            string clientes = filaclientes.Dequeue();
            Console.WriteLine($"Atendendo o cliente {clientes}...");
        }
        Console.WriteLine();
        Console.WriteLine("Todos os clientes foram atendidos!");
    }
}