using System;

namespace Concatenação

{
    class Program
 
    {
        static void Main(string[] args)

        {
           string nome = "Marcelo", sobrenome = "Bertochi";

           
           string completo = $"Meu nome completo é {nome} {sobrenome}";

           Console.WriteLine(completo);

           
           Console.WriteLine($"Meu nome completo é {nome} {sobrenome}");



        }
    }
}
