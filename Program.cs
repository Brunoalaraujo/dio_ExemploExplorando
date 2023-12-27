using dio_ExemploExplorando.Models;
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Siclano", sobrenome: "Alfa"); // Colocar nome do parâmetro para facilitar entendimento

Pessoa p2 = new Pessoa("Fulano", "Teste"); //Segundo modelo de construtor de Pessoa

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();