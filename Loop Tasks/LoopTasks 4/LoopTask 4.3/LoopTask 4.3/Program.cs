using System;

namespace LoopTask_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä [0-50].\n");

            int rndNumber;
            int i;

            Random rnd = new Random();
            rndNumber = rnd.Next();
           
            for (i = 1; i < 6; i++)
            {
                Console.WriteLine("Rivi " + i + ": " + rnd.Next(0, 50) + "," + rnd.Next(0, 50) + "," + rnd.Next(0, 50) +"," + rnd.Next(0, 50) +"," + rnd.Next(0, 50));
            }
            Console.ReadKey();
        }
    }
}
