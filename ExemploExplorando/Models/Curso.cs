using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        private string _nome;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa pessoa)
        {
            Alunos.Add(pessoa);
        }

        public int ObterQuantidadeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            bool remover = Alunos.Remove(aluno);
            return remover;
        }

        // para cada obj pessoa na lista de Alunos...
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"Aluno: {aluno.NomeCompleto}");
            }
        }
    }
}