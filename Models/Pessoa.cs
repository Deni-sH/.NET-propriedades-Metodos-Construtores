using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {

        private string _nome;
        public string Nome
        {

        

         get
            {
                return _nome.ToUpper();
                //retornar o nome maiusculo
            }

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





        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade}.");
        }
    }
}
