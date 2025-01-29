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

Calculadora calculadora = new Calculadora();

calculadora.Somar(3, 5);
calculadora.Subtrair(8, 4);
calculadora.Multiplicar(2, 8);
calculadora.Dividir(18, 9);
calculadora.Potencia(2, 6);
