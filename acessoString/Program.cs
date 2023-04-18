using System;

namespace Concatenação

{
    class Program

    {
        static void Main(string[] args)

        {
            /*
            string nome = "Marcelo";

            Console.WriteLine($"O nome Marcelo tem {nome.Length}");

            Console.WriteLine($"A primeira letra do nome Marcelo é {nome[0]}");
            Console.WriteLine($"A primeira letra do nome Marcelo é {nome[1]}");
            Console.WriteLine($"A primeira letra do nome Marcelo é {nome[2]}");
            Console.WriteLine($"A primeira letra do nome Marcelo é {nome[3]}");
            Console.WriteLine($"A primeira letra do nome Marcelo é {nome[4]}");
            Console.WriteLine($"A primeira letra do nome Marcelo é {nome[5]}");
            Console.WriteLine($"A primeira letra do nome Marcelo é {nome.ToUpper()[6]}");

            Console.WriteLine($"O Índice da Letra r da variável nome é {nome.IndexOf("r")}");
            */
            // Criado a variavel nome com valor Marcelo
            string nome = "Marcelo";

            // localizando a letra "c" na variável Nome
            int charPos = nome.IndexOf("c");

            // pega da letra encontrada em diante
            string metadeNome = nome.Substring(charPos);

            // print do resultado
            Console.WriteLine(metadeNome);







        }
    }
}
