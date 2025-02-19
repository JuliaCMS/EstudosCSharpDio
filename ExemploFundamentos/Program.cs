using System.Globalization;
using System.Runtime.CompilerServices;
using ExemploFundamentos.Models;


// Operadores

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 5;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"É possível realizar a venda?: {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine($"Venda realizada. \nProdutos comprados: {quantidadeCompra}");
//     int estoqueAtual = quantidadeEmEstoque - quantidadeCompra;
//     Console.WriteLine($"Quantidade atual em estoque: {estoqueAtual}");
// }
// else
// {
//     Console.WriteLine("Venda não realizada. Quantidade em estoque insuficiente para a compra");
// }












// Switch-Case

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;

//     default:
//         Console.WriteLine("não é vogal");
//         break;
// }

















// Calculadora

// Calculadora calculadora = new Calculadora();

// calculadora.Somar(3, 5);
// calculadora.Subtrair(8, 4);
// calculadora.Multiplicar(2, 8);
// calculadora.Dividir(18, 9);
// calculadora.Potencia(2, 6);























// Estruturas de repetição

// FOR
// int numero = 5;

// for (int i = 1; i <= 10; i++)
// {
//     int multiplicacao = numero * i;
//     System.Console.WriteLine($"{numero} X {i} = {multiplicacao}");
// }

// WHILE

// int numero = 5;
// int i = 1;

// while (i <= 10) 
// {
//     int multiplicacao = numero * i;
//     Console.WriteLine($"{numero} x {i} = {multiplicacao}");

//     i++;

//     if (i == 6) // quero que vá até a quinta execução
//     {
//         break; // sai do laço
//     }
// }






















// DO WHILE

// int numero = 5;
// int i = 1;

// do
// {
//     int multiplicacao = numero * i;
//     System.Console.WriteLine($"{numero} x {i} = {multiplicacao}");

//     i++;
// } while (i <= 10);

























// MENU INTERATIVO

// int opcao;
// bool continuar = true;

// while (continuar)
// {
//     System.Console.WriteLine("OPÇÕES");
//     Console.WriteLine("Opçao 1 - Cadastrar cliente.");
//     Console.WriteLine("Opçao 2 - Buscar cliente.");
//     Console.WriteLine("Opçao 3 - Apagar cliente.");
//     Console.WriteLine("Opçao 4 - Encerrar.");
//     Console.Write("Digite a sua opção: ");
//     opcao = Convert.ToInt32(Console.ReadLine());

//     switch (opcao)
//     {
//         case 1:
//             Console.WriteLine("Cadastrar Cliente.");
//             break;

//         case 2:
//             Console.WriteLine("Buscar cliente.");
//             break;

//         case 3:
//             Console.WriteLine("Apagar Cliente.");
//             break;

//         case 4:
//             Console.WriteLine("Encerrar.");
//             continuar = false;
//             break;

//         default:
//             System.Console.WriteLine("Opcao Inválida");
//             break;
//     }
// }





















// Array

// Formas de escrever:
// int[] numeros = { 1, 2, 3, 4 };
// string[] nomes = new string[4] { "Julia", "Caio", "Rosi", "etc" };
// int[] exemplo = new int[4];
// exemplo[0] = 1;
// Console.WriteLine(nomes[4]);




// int[] inteiros = new int[3];
// inteiros[0] = 34;
// inteiros[1] = 65;
// inteiros[2] = 79;

// for (int i = 0; i < inteiros.Length; i++)
// {
//     System.Console.WriteLine($"Indice {i}: {inteiros[i]}");
// }

// int contadorForeach = 0;
// foreach (int valor in inteiros)
// {
//     System.Console.WriteLine($"posição {contadorForeach}: {valor}");
//     contadorForeach++;
// }

// Array.Resize(ref inteiros, 7);

// inteiros[3] = 54;
// inteiros[4] = 4;
// inteiros[5] = 98;
// inteiros[6] = 23;

// System.Console.WriteLine(inteiros[5]);

// int[] arrayDobrados = new int[inteiros.Length * 2];
// Array.Copy(inteiros, arrayDobrados, inteiros.Length);






















// Listas

List<string> listaEstados = new List<string>();

listaEstados.Add("SP");
listaEstados.Add("BA");

System.Console.WriteLine("Percorrendo com o FOR");
for (int i = 0; i < listaEstados.Count; i++)
{
    System.Console.WriteLine($"Posicão {i}: {listaEstados[i]}");
}

System.Console.WriteLine("Percorrendo com o ForEach");
foreach (string item in listaEstados)
{
    System.Console.WriteLine(item);
}