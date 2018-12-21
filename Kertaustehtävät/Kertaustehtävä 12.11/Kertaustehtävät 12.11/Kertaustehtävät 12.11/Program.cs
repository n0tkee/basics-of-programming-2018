using System;

namespace Kertaustehtävät_12._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput1 = 0;
            int userInput2 = 1;
            Console.WriteLine("Syötä luku:");

            do
            {
                Console.WriteLine("Syötä luku:");
                userInput1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Syötä luku:");
                userInput2 = int.Parse(Console.ReadLine());
            }
            while (userInput1 != userInput2);
            //{
            //    Console.WriteLine("Syötä luku:");
            //    userInput1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Syötä luku:");
            //    userInput2 = int.Parse(Console.ReadLine());
            //}
            Console.WriteLine("Lukujen summa on: {0}", userInput1 + userInput2);
            Console.ReadKey();
        }
    }
}

