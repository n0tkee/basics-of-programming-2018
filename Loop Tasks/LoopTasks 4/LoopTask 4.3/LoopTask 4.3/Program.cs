using System;

namespace LoopTask_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int rndNumber;
            int i;

            Random rnd = new Random();
            rndNumber = rnd.Next(0,50);
           
            for (i = 1; i < 6; i++)
            {
                //rndNumber = rnd.Next(0, 50);
                Console.WriteLine("Rivi " + i + ":" + rnd.Next(0, 50) + "," + rnd.Next(0, 50) + "," + rnd.Next(0, 50) +"," + rnd.Next(0, 50) +"," + rnd.Next(0, 50));
            }
            Console.ReadKey();
        }
    }
}
