using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private string _sobrenome;

        // Construtores 
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Propriedades
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser inferior a 0.");
                }

                _idade = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome.ToUpper();
            set => _sobrenome = value;
        }

        // Métodos
        public string NomeCompleto => Nome + " " + Sobrenome;

        public void Apresentar()
        {
            System.Console.WriteLine($"Nome: {NomeCompleto} \nIdade: {Idade}");
        }
    }
}