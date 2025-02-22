using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Julia";
p1.Sobrenome = "Mourão";
// p1.Idade = 28;
// p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Caio";
p2.Sobrenome = "Reimberg";

// objeto pessoa instanciado com construtor
Pessoa p3 = new Pessoa("Rosimeire", "Mourão");
Pessoa p4 = new Pessoa(nome: "Joaquim", sobrenome: "Oliveira");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>();
cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.AdicionarAluno(p3);
cursoIngles.AdicionarAluno(p4);
cursoIngles.AdicionarAluno(new Pessoa("Ana", "Maria"));
cursoIngles.ListarAlunos();