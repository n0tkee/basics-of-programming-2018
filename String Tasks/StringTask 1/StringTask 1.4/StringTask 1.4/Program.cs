using System;

namespace StringTask_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa onko käyttäjältä kysytty sana tai lause palintromi.\n");

            Console.Write("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();
            string testWord = userInput.ToUpper();

            palindromeCheck(testWord);

            Console.ReadKey();
        }

        static void palindromeCheck(string d)
        {
            char[] toChars = d.ToCharArray();
            Array.Reverse(toChars);
            string backwards = new string(toChars);

            if (d == backwards)
            {
                Console.WriteLine("\nSana {0} on palindromi", d);
            }

            else
            {
                Console.WriteLine("\nSana {0} ei ole palindromi", d);
            }
        }

    }
}
