using exercicioo13;

Console.Write("Digite a capacidade da fila: ");
int capacidade = int.Parse(Console.ReadLine());

FilaCircular fila = new FilaCircular(capacidade);
int opcao;

do
{
    Console.WriteLine("--------------------");
    Console.WriteLine("1. Enfileirar");
    Console.WriteLine("2. Desenfileirar");
    Console.WriteLine("3. Mostrar fila");
    Console.WriteLine("0. Sair");
    Console.WriteLine("--------------------");
    Console.WriteLine();
    Console.Write("Escolha uma opção: ");
    Console.WriteLine();
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite um valor para enfileirar: ");
            int valor = int.Parse(Console.ReadLine());
            fila.Enfileirar(valor);
            break;

        case 2:
            fila.Desenfileirar();
            break;

        case 3:
            fila.MostrarFila();
            break;

        case 0:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (opcao != 0);