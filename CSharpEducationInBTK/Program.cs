using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditionals

            int number = 10;

            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");  // Tek satırda if else yapısı (with ReSharper)

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            Console.WriteLine(number == 10 ? "Number is 10" : number == 20 ? "Number is 20" : "Number is not 10 or 20");  // Tek satırda if - else if - else yapısı (without ReSharper)

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }
        }
    }
}