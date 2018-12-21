using System;
using System.Linq;
using System.Globalization;

namespace Kertaustehtävä_3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä lause");
            string userInput = Console.ReadLine();
            //string[] words = userInput.Split(" ");
            //string[] proposition = { "the", "of" };

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine(myTI.ToTitleCase(userInput));

            //Console.WriteLine(words[0]);
            //Console.WriteLine(words[1]);
            //Console.WriteLine(words[2]);

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i].ToUpper());
            //    words[i].ToUpper();
            //}


            //Console.WriteLine(words[0]);

            //words[1].ToUpper();
            //Console.WriteLine(words[1]);
            //Console.WriteLine(words[2]);

            //string str = string.Join(" ", words);
            //Console.WriteLine(words[2]);
            //Console.WriteLine(str);
            //Console.WriteLine(str);
            //Console.WriteLine(words[2]);
            Console.ReadKey();
        }
    }
}
