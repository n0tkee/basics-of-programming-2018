using System;

namespace StringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä (DATA) tiedosta vokaalien lukumäärän\n");

            Console.WriteLine("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();
            string testWord = userInput.ToUpper();

            char[] userInputToChar = testWord.ToCharArray();
            int vowel = 0;

            for (int i = 0; i < userInputToChar.Length; i++)
            {
                if (userInputToChar[i] == 'A' || userInputToChar[i] == 'E' || userInputToChar[i] == 'I' ||
                    userInputToChar[i] == 'O' || userInputToChar[i] == 'U' || userInputToChar[i] == 'Y' ||
                    userInputToChar[i] == 'Ä' || userInputToChar[i] == 'Ö')
                {
                    vowel++;
                }
            }
            Console.WriteLine("\nSyötteessä {0} on {1} vokaalia", testWord, vowel);
            Console.ReadLine();

        }
    }
}
