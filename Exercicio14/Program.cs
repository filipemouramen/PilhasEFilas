
FilaPrioridade fila = new FilaPrioridade();

fila.Enqueue("Limpar casa", 1);
fila.Enqueue("Estudar", 3);
fila.Enqueue("Jogar", 2);

fila.MostrarFila();

Console.WriteLine();
fila.Dequeue();
fila.MostrarFila();

Console.WriteLine();
fila.Dequeue();
fila.MostrarFila();

Console.WriteLine();
fila.Dequeue();
fila.MostrarFila();
