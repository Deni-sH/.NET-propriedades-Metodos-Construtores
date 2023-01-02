using propriedades_metodos.Models;

Pessoa p1 = new Pessoa(nome: "Denis", sobrenome: "Hara");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Massuda");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.ListarAlunos();



//Get obtendo valor armazenado nessa propriedade como ex:{Idade}. Set = setando/ atribuindo valor ex. = 25.

