Console.WriteLine("Digite um número decimal (com vírgula se quiser): ");
double numero = double.Parse(Console.ReadLine());

int parteInteira = (int)numero;
double parteFracionaria = numero - parteInteira;

string binarioInteiro = "";
if (parteInteira == 0)
{
    binarioInteiro = "0";
}
else
{
    while (parteInteira > 0)
    {
        binarioInteiro = (parteInteira % 2) + binarioInteiro;
        parteInteira /= 2;
    }
}

string binarioFracao = "";
int limite = 5;
while (parteFracionaria > 0 && limite-- > 0)
{
    parteFracionaria *= 2;
    int bit = (int)parteFracionaria;
    binarioFracao += bit;
    parteFracionaria -= bit;
}

if (binarioFracao != "")
{
    Console.WriteLine("Binário: " + binarioInteiro + "." + binarioFracao);
}
else
{
    Console.WriteLine("Binário: " + binarioInteiro);
}