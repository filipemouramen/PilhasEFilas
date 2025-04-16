using Exercicio17;

GerenciadorImpressao gerenciador = new GerenciadorImpressao();
int opcao;

do
{
    Console.WriteLine();
    Console.WriteLine("--------Menu Impressora-------");
    Console.WriteLine("1. Adicionar documento");
    Console.WriteLine("2. Imprimir próximo documento");
    Console.WriteLine("3. Mostrar filas");
    Console.WriteLine("0. Sair");
    Console.WriteLine("------------------------------");
    Console.WriteLine();
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o nome do documento: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a prioridade do documento(alta/baixa): ");
            string prioridade = Console.ReadLine();
            gerenciador.AdicionarDocumento(new Documento(nome, prioridade));
            break;

        case 2:
            gerenciador.ImprimirProximo();
            break;

        case 3:
            gerenciador.MostrarFilas();
            break;

        case 0:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (opcao != 0);