using propriedades_metodos.Models;
using System.Globalization;



try
{
    string[] linhas = File.ReadAllLines("arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}








Console.WriteLine("Chegou aqui");






/* links Lucas B.

https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/tokens/interpolated

https://docs.microsoft.com/pt-br/dotnet/standard/base-types/custom-numeric-format-strings

https://docs.microsoft.com/pt-br/dotnet/api/system.datetime

https://riptutorial.com/csharp/example/19285/datetime-tryparseexact-string--string--iformatprovider--datetimestyles--datetime-




Existe um outro meio de concatenar strings, em que usamos o sinal de "$". Essa concatenação é chamada de:
R-> interpolação juntar-> ("$ {data}");


concatenar strings = +  

Podemos alterar a localização (ou cultura) do programa para que seja trabalhado dados específicos de uma cultura (por exemplo, símbolo da moeda, casas decimais, etc). Para isso, usamos a classe:
R-> CultureInfo

Para formatar um valor decimal, ou seja, colocar o símbolo de moeda, é correto usarmos o caractere:
R-> :C





// DateTime tryparse -----------------------------------------

// maneira segura de conversão

// string dataString = "2022-13-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, out DateTime data);

                     


// if (sucesso) {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}"); = Conversão com sucesso! Data: 17/12/2022 18:00:00
// }
// else {
//     Console.WriteLine($"Error Data: {data}"); = Error Data: 01/01/0001 00:00:00
// }



// -------------------------------------DateTime



/*
//método para que mesmo se der erro ele funcione = 01/01/0001 00:00:00
string dataString = "2022-13-17 18:00";

DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime data);

                        Console.WriteLine(data);


*/



// DateTime data = DateTime.Parse("17/04/2022 18:00"); = 17/04/2022 18:00:00 conversão de numero para string


// Console.WriteLine(data);



// ----------------------------

// using System.Globalization;

// DateTime data = DateTime.Now;    


// Console.WriteLine(data.ToShortTimeString()); = 16:07

// Console.WriteLine(data.ToShortDateString()); = 03/01/2023

//MM:Mês  HH ->Hora. mm->Minuto. OBS: hh minúsculo formato de 12h. 
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); = 03/01/2023 16:00


























// ---------------------------------------------------------------------------
/*
//modificar cultura do sistema. \/
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 84.40M;
                                 //:C = Currence
// Console.WriteLine($"{valorMonetario:C}"); 

//abaixo usar outra cultura atropelando a cultura do sistema
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); 

//C-> CURRENCE/ 8-> CASAS DECIMAIS = 84,40000000
Console.WriteLine(valorMonetario.ToString("C8")); 

//Porcentagem \/ = 12,34%
double porcentagem = .1234;
Console.WriteLine(porcentagem.ToString("P"));


//resultado = 34-21-35
int numero = 341235;
Console.WriteLine(numero.ToString("##-##-##"));

*/




























/*
Pessoa p1 = new Pessoa(nome: "Denis", sobrenome: "Hara");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Massuda");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.ListarAlunos();
*/

/*
construtor: atribuir valores para um objeto
Get obtendo valor armazenado nessa propriedade como ex:{Idade}. Set = setando/ atribuindo valor ex. = 25.

Quando queremos proteger uma variável de modificações externas, isto é, 
impedir que ela seja alterada a não ser pela própria classe, usamos o modificador: private


 EX: Temos a possibilidade de implementar uma propriedade que apenas retorna um valor, não sendo possível atribuir ou modificar o valor retornado. 
Esse tipo de propriedade é conhecida como: Propriedade somente leitura, onde implementa apenas o GET.

EX2: Existem dois tipos de ações de propriedades: GET e SET. 
Eles podem manipular variáveis ou ser auto implementadas, e suas funções são: 
= GET: Obter o valor da propriedade; SET: Atribuir o valor da propriedade.
*/



//guia Lucas 
/*
propriedades:
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties

métodos:
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/methods

construtores:
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/constructors



construtores estaticos: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/static-constructors

*/
