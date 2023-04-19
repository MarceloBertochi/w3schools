using System;

namespace Boleanos

{
    class Program

    {
        static void Main(string[] args)

        {
            bool cCharpdivertido = true;
            bool peixegostoso = false;

            Console.WriteLine(cCharpdivertido);
            Console.WriteLine(peixegostoso);

            int x = 10, y = 15;

            Console.WriteLine(x > y);

            Console.WriteLine(x == 10);

            Console.WriteLine(10 == 15);

            int idade;

            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é velha o suficiente para votar");
            }



            else
            {
                Console.WriteLine("Você ainda é um bebê e não pode votar");
            }


        }
    }
}
