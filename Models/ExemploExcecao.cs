using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos.Models
{
    public class ExemploExcecao
    {

             public void Metodo1()
            {
                try
                {
                    Metodo2();
                }catch(Exception ex)
                {
                    Console.WriteLine("Exceção tratada. " + ex.Message);
                }
            }

            public void Metodo2()
            {
                Metodo3();
            }
            public void Metodo3()
            {
                Metodo4();
            }
            public void Metodo4()
            {
                throw new Exception("Ocorreu uma exceção!");
            }

    }
 }
/* executacução Program.cs>new ExemploExcecao().metodo1();
throw executa de baixo pra cima para tentar tratar a exceção.

obs: Quando nós não tratamos uma exceção, ele vai executar o caminho de volta até ter alguem que tenha exceção, que trate isso para nós. 
se não tiver ninguem ele vai executar o stackTrace (caminho que ele fez)
*/


