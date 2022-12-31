using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos.Models
{
    public class Pessoa
    {

        private string _nome;
        private int _idade;
        public string Nome
        {

            //segunda forma.
            get => _nome.ToUpper();

            /* primeira forma
                     get
                        {
                            return _nome.ToUpper();
                            //retornar o nome maiusculo
                        } */

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                    //não permite vazio.
                }

                _nome = value;

            }



        }

        public string Sobrenome { get; set; }
        public string nomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        // junção utilizando valores já existentes. Usa somente o get.

        public int Idade 
        
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"A idade não pode ser menor que zero");
                }

                _idade = value;
            }


        }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {nomeCompleto} e tenho {Idade}.");
        }
    }
}
