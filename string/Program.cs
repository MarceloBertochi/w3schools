using System;

namespace EstudodeString

{
    class Program

    {
        static void Main(string[] args)

        {
            //Crie uma variável do tipo string e atribua um valor a ela:
            string nome = "Marcelo tirou nota MB em programação na Etec";

            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            Console.WriteLine("A variável nome tem entre letras e espaços " + nome.Length + " caracteres");
        }
    }

}




