using System;

namespace IfElse

{
    class Program

    {
        static void Main(string[] args)

        {
            /*
             if (20 > 18)
             {
                 Console.WriteLine("20 é maior que 18");
             }
             */
            /*
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x é maior que y");
            }
            */

            /*
             int time = 20;
             if (time < 18)
             {
                 Console.WriteLine("Bom dia.");
             }
             else
             {
                 Console.WriteLine("Boa noite.");
             }
             */

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Bom dia.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Boa tarde.");
            }
            else
            {
                Console.WriteLine("Boa noite.");
            }



        }
    }
}
