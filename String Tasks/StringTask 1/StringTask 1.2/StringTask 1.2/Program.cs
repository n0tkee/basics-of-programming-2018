using System;

namespace StringTask_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa käyttäjän syöttämästä syötteestä e kirjaimet @ merkiksi:");
            string userInput = Console.ReadLine();
            string userInput1 = userInput.Replace('e', '@');
            Console.WriteLine(userInput1);
            Console.ReadKey();
        }
    }
}