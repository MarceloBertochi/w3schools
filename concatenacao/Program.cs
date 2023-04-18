using System;

namespace Concatenação

{
    class Program

    {
        static void Main(string[] args)

        {
            string nome = "Marcelo ", sobrenome = "Bertochi";


            Console.WriteLine(nome + sobrenome);

            string completo = string.Concat(nome, sobrenome);

            // int x = 10, y = 20;
            //Console.WriteLine(x + y);

            string x = "10", y = "20";
            Console.WriteLine(x + y);

        }
    }
}


