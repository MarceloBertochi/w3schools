/*
escreva um programa c # para trocar números de digitados.
dados de teste:
digitte o primeiro número: 
digite o segundo número: 
o ato de trocar as variáveis ​​refere-se à troca mútua dos valores das variáveis.
Geralmente, isso é feito com os dados na memória usando uma variável temporária:
o método mais simples para trocar as variáveis ​​é usar uma terceira variável temporária:
definir troca (x,y)
temporaria = x
x = Y
y = temporaria
*/

using System;

namespace Exercicio03

{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Clear();
            int numero01, numero02, temp;

            Console.WriteLine("digite o primeiro número : ");
            numero01 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o Segundo número : ");
            numero02 = int.Parse(Console.ReadLine());

            temp = numero01;
            numero01 = numero02;
            numero02 = temp;

            Console.WriteLine("O primeiro número digitado virou : " + numero01);
            Console.WriteLine("O segundo número digitado virou : " + numero02);
            Console.WriteLine();

            Console.WriteLine("E ai gostou?");
        }
    }
}


