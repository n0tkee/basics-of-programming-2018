using System;

namespace ItsearviontiTehtävä_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Syötä luku: \n");
            Console.WriteLine("Input");

            while (true)
            {
                Console.Write("");
                int userInput = int.Parse(Console.ReadLine());
                sum = sum + userInput;

                if(userInput == -1)

                {
                    break;
                }
            }
            Console.WriteLine("\nOutput: Lukujen summa on " + (sum +1));
            Console.ReadKey();
        }
    }
}

