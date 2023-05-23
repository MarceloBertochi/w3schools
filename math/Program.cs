using System;

namespace ConfiguraçõesMatemáticas

{
    class Program

    {
        static void Main(string[] args)

        {
            int x = 150, y = -200;

            Console.WriteLine(Math.Max(x, y)); // retorna o maior valor
            Console.WriteLine(Math.Min(x, y)); // retorna o menor valor
            Console.WriteLine(Math.Sqrt(x + y)); // retorna a raiz quadrada de x + y 
            Console.WriteLine(Math.Abs(x + y)); // retorna o valor absoluto de x + y
            Console.WriteLine(Math.Round(9.99)); // arredonda o valor para o número inteiro mais próximo
        }
 
    }
}
