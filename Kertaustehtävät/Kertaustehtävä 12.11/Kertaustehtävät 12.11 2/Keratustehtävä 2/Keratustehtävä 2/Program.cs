using System;

namespace Kertaustehtävät_12._11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minäpä teidän luvun väliltä 1-100, jota sinä et tiedä!");
            Random Rnd = new Random();
            int RndNum = Rnd.Next(1,100);
            int numOfattempts = 0;
            int attempt = 0;

            while (attempt != RndNum)
            {
                Console.Write("Syötä luku: ");
                attempt = int.Parse(Console.ReadLine());
                numOfattempts++;


                if(attempt > 100 || attempt < 1)
                {
                    Console.WriteLine("Epäkelpo luku!");
                }

                else if (attempt > RndNum)
                {
                    Console.WriteLine("Lukuni on pienempi!");
                }

                else if (attempt < RndNum)
                {
                    Console.WriteLine("Lukuni on suurempi!");
                }
            }

            Console.WriteLine($"\nOikein! Arvauksia yhteensä: {numOfattempts}");

            Console.ReadKey();

        }
    }
}