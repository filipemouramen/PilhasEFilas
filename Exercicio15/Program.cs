Stack<string> estacionamento = new Stack<string>();
int capacidade = 5;

while (true)
{
    Console.WriteLine("--- Estacionamento ---");
    Console.WriteLine("1. Entrar com carro");
    Console.WriteLine("2. Sair com carro");
    Console.WriteLine("3. Mostrar estacionamento");
    Console.WriteLine("0. Sair");
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        if (estacionamento.Count >= capacidade)
        {
            Console.WriteLine("Estacionamento cheio.");
        }
        else
        {
            Console.Write("Placa do carro: ");
            string placa = Console.ReadLine();
            estacionamento.Push(placa);
            Console.WriteLine($"Carro {placa} entrou.");
        }
    }
    else if (opcao == "2")
    {
        if (estacionamento.Count == 0)
        {
            Console.WriteLine("Estacionamento vazio.");
            continue;
        }

        Console.Write("Placa do carro que quer sair: ");
        string placa = Console.ReadLine();

        Stack<string> temp = new Stack<string>();
        bool achou = false;

        while (estacionamento.Count > 0)
        {
            string topo = estacionamento.Peek();
            if (topo == placa)
            {
                estacionamento.Pop(); 
                Console.WriteLine($"Carro {placa} saiu.");
                achou = true;
                break;
            }
            else
            {
                temp.Push(estacionamento.Pop());
            }
        }

        while (temp.Count > 0)
        {
            estacionamento.Push(temp.Pop());
        }

        if (!achou)
        {
            Console.WriteLine($"Carro {placa} não está no estacionamento.");
        }
    }
    else if (opcao == "3")
    {
        Console.WriteLine("Carros no estacionamento:");

        foreach (var carro in estacionamento)
        {
            Console.WriteLine($" - {carro}");
        }
    }
    else if (opcao == "0")
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}