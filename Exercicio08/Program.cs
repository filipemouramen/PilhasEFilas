using System;
using System.Collections.Generic;
using Exercicio08;

Console.WriteLine("Digite a sequência de parenteses");
string entrada = Console.ReadLine();

if (Balanceado.VerificaBalanceado(entrada))
{
    Console.WriteLine("A sequência de parenteses está balanceada");
}
else
{
    Console.WriteLine("A sequência de parenteses não está balanceada");
}