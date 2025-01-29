using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"{a} + {b} = {resultado}");
        }

        public void Subtrair(int a, int b)
        {
            int resultado = a - b;
            Console.WriteLine($"{a} - {b} = {resultado}");
        }

        public void Multiplicar(int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine($"{a} X {b} = {resultado}");
        }

        public void Dividir(int a, int b)
        {
            int resultado = a / b;
            Console.WriteLine($"{a} / {b} = {resultado}");
        }

        public void Potencia(int a, int b)
        {
            double resultado = Math.Pow(a, b);
            System.Console.WriteLine($"{a}^{b} = {resultado}");
        }

        // Math.Round(a, 2); -> arredonda o valor com duas casas decimais
    }
}