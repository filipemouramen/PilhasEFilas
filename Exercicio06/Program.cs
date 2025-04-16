using System.Collections;
using System.Collections.Generic;

namespace Pilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pagina = new Stack<string>();

            string paginaAtual = null;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("O que deseja fazer hoje?");
                Console.WriteLine();
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Acessar nova página");
                Console.WriteLine("2. Voltar a página anterior");
                Console.WriteLine("3. Mostrar página atual");
                Console.WriteLine("4. Sair");
                Console.WriteLine("----------------------------");
                Console.WriteLine();

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome da nova página:");
                        string novaPagina = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Você está acessando a página: {novaPagina}");

                        if (paginaAtual != null)
                        {
                            pagina.Push(paginaAtual);
                        }

                        paginaAtual = novaPagina;

                        Console.WriteLine();
                        Console.WriteLine($"Você acessou a página: {paginaAtual}");
                        break;

                    case "2":
                        if (pagina.Count > 0)
                        {
                            paginaAtual = pagina.Pop();
                            Console.WriteLine($"Você voltou para a página: {paginaAtual}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Não há páginas anteriores.");
                            Console.WriteLine();
                        }
                        break;

                    case "3":
                        if (paginaAtual != null)
                        {
                            Console.WriteLine($"Página atual: {paginaAtual}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma página acessada");
                            Console.WriteLine();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saindo...");
                        return;
                }
            }
        }
    }
}