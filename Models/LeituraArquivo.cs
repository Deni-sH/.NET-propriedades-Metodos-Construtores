using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos.Models
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[] linhas , int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {

            string[] linhas = File.ReadAllLines(caminho); //LeituraArquivo todas as linhyas de arquivo que eu passar
            return (true, linhas, linhas.Count()); //sucesso


            }catch(Exception)
          
            {
                return (false, new string[0], 0); //falha

            }

         /*não queremos que ele exiba um resultado em terminal aqui, queremos 
        que ele retorne para quem chamou, entao vou ler o arquivo, 
        mas eu retorno as linhas pra quem chamou, 
        não quero que ele escreva no terminal nesse método
        */
    }
    }
}