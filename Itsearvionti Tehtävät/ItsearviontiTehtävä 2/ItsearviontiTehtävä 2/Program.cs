using System;

namespace ItsearviontiTehtävä_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa käyttäjän syöttämän lauseen tai sanan niin monta kertaa kuin sanassa tai lauseessa on kirjaimia.\n");

            Console.Write("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();

            int i = 0;

            for (i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine(userInput);

            }

            Console.ReadKey();
        }
    }
}
