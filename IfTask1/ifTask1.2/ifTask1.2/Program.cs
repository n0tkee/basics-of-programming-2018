using System;

namespace ifTaks1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku parillinen " +
                "vai pariton.");
            Console.Write("syötä luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number % 2 == 0)
                Console.WriteLine($"Numero {number} on parillinen!");
            else
                Console.WriteLine($"Numero {number} on pariton");
      


        }

    }
}