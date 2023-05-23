using System;

namespace EstudoSwitch

{
    class Program

    {
        static void Main(string[] args)

        {
            int day = 4;

           switch (day)
           {
            case 7:
            Console.WriteLine("Hoje é Quinta");
            break;

            case 8:
            Console.WriteLine("Hoje é Sexta");
            break;

            default:
            Console.WriteLine("Ansioso pelo final de semana");
            break;
           }
           
           
           
           
           /* switch (day)
            {
                case 1:
                Console.WriteLine("Segunda");
                break;

                case 2:
                Console.WriteLine("Terça");
                break;

                case 3:
                Console.WriteLine("Quarta");
                break;

                case 4:
                Console.WriteLine("Quinta");
                break;

                case 5:
                Console.WriteLine("Sexta");
                break;

                case 6:
                Console.WriteLine("Sábado");
                break;

                case 7:
                Console.WriteLine("Doming");
                break;
            }*/
        }
    }
}
