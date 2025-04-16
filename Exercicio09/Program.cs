using Exercicio09;
using System.Security.Cryptography.X509Certificates;

Queue<string> fila = new Queue<string>();

fila.Enqueue("Ana");
fila.Enqueue("Carlos");
fila.Enqueue("Beatriz");
fila.Enqueue("Daniel");
fila.Enqueue("Eduardo");
fila.Enqueue("Fernanda");
fila.Enqueue("Gabriel");
fila.Enqueue("Helena");

Console.WriteLine("Fila original:");
foreach (string i in fila)
{
    Console.WriteLine(i);
}

PilhaInverter.InverterFila(fila);

Console.WriteLine();
Console.WriteLine("Fila invertida:");

foreach (string i in fila)
{
    Console.WriteLine(i);
}

