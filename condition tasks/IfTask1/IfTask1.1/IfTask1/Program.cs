using System;

namespace ifTaks1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku positiivinen " +
                "positiivinen, " +
                "negatiivinen vai nolla.");

            int number;

            Console.Write("syötä luku: ");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
                Console.WriteLine($"Numero {number} on nolla!");
            else if (number < 0)
                Console.WriteLine($"Numero {number} on negatiivinen");
            else
                Console.WriteLine($"Numero {number} on positiivinen!");


        }

    }
}