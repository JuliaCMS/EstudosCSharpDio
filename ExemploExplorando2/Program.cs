// // Tratamento de exceções

// try
// {
//     string[] linhas = File.ReadAllLines("Files/ArquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu um erro genérico. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }

















// // Filas

// Queue<int> filaInteiros = new Queue<int>();

// filaInteiros.Enqueue(2);
// filaInteiros.Enqueue(4);
// filaInteiros.Enqueue(6);
// filaInteiros.Enqueue(8);

// filaInteiros.Dequeue(); // nao aceita argumentos pois ele sempre vai remover o primeiro (FIFO)

// foreach (int item in filaInteiros)
// {
//     System.Console.WriteLine(item);
// }





















// // Pilhas 

// Stack<int> pilhaInteiros = new Stack<int>();

// pilhaInteiros.Push(2);
// pilhaInteiros.Push(4);
// pilhaInteiros.Push(6);
// pilhaInteiros.Push(8);

// foreach (int item in pilhaInteiros)
// {
//     System.Console.WriteLine(item);
// }

// pilhaInteiros.Pop();

// foreach (int item in pilhaInteiros)
// {
//     System.Console.WriteLine(item);
// }



















// Dictionary

Dictionary<int, string> dicionario = new Dictionary<int, string>();

// Adicionando valores
dicionario.Add(1, "Maçã");
dicionario.Add(2, "Banana");
dicionario.Add(3, "Laranja");

// Acessando valores
Console.WriteLine(dicionario[1]); // Saída: Maçã

// Verificando se uma chave existe
if (dicionario.ContainsKey(2))
{
    Console.WriteLine("A chave 2 existe!");
}

// Iterando sobre o Dictionary
foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Removendo um item
dicionario.Remove(3);

