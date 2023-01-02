using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
//usar o for: pois se for o foreach precisaria incrementar e gerenciar uma variável 
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}"); //aparece ingles por conta das chaves.

            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº " + count + " - " + Alunos[count].nomeCompleto;  \/ interpolação de strings.- (count +1)<-ajustedenumeração

                string texto = $"Nº {count +1} - {Alunos[count].nomeCompleto}";
                Console.WriteLine(texto);
            }
        }





    }

}