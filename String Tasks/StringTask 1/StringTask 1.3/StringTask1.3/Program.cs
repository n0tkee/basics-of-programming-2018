using System;

namespace StringTask_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä syötteestä L kirjainten lukumäärän");
            string userInput = Console.ReadLine();
            string userInputUpper = userInput.ToUpper();

            Console.WriteLine("Syötteessä {0} on {1} L kirjainta.",userInputUpper, countChars(userInputUpper, 'L'));
            Console.ReadKey();
        }
        static int countChars(string text, char c)
        {
            int count = 0;
            foreach (char ch in text)
            {
                if(ch.Equals(c))
                {
                    count++;
                }
            } return count;
        }
    }
}