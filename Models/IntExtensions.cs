using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos.Models
{
    public static class IntExtensions
    {//if ternario
        public static bool EhPar(this int numero)
        {
              return numero % 2 == 0; 
        }
           
    }
}