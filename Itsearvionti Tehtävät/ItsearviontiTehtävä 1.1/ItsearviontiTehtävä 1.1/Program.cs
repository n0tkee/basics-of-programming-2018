using System;

namespace ItsearviontiTehtävä_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(userInput);

            }

            Console.ReadKey();
        }
    }
}
