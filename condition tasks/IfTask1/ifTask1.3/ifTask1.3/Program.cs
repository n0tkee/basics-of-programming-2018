using System;

namespace ifTask1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku parillinen " +
        "vai pariton, sekä onko annettu luku  " +
       "positiivinen, " +
       "negatiivinen vai nolla.");

            Console.Write("syötä luku: ");
            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);

            if (number % 2 == 0)
                Console.WriteLine($"Numero {number} on parillinen!");
            else
                Console.WriteLine($"Numero {number} on pariton");
            if (number == 0)
                Console.WriteLine($"Numero {number} on nolla!");
            else if (number < 0)
                Console.WriteLine($"Numero {number} on negatiivinen");
            else
                Console.WriteLine($"Numero {number} on positiivinen!");


        }
    }
}
