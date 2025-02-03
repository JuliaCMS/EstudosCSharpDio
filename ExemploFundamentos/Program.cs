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

int opcao;
bool continuar = true;

while (continuar)
{
    System.Console.WriteLine("OPÇÕES");
    Console.WriteLine("Opçao 1 - Cadastrar cliente.");
    Console.WriteLine("Opçao 2 - Buscar cliente.");
    Console.WriteLine("Opçao 3 - Apagar cliente.");
    Console.WriteLine("Opçao 4 - Encerrar.");
    Console.Write("Digite a sua opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastrar Cliente.");
            break;

        case 2:
            Console.WriteLine("Buscar cliente.");
            break;

        case 3:
            Console.WriteLine("Apagar Cliente.");
            break;

        case 4:
            Console.WriteLine("Encerrar.");
            continuar = false;
            break;

        default:
            System.Console.WriteLine("Opcao Inválida");
            break;
    }
}