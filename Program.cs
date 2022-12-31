using propriedades_metodos.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Denis";
p1.Sobrenome = "Hara";

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Massuda";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.ListarAlunos();



//Get obtendo valor armazenado nessa propriedade como ex:{Idade}. Set = setando/ atribuindo valor ex. = 25.

