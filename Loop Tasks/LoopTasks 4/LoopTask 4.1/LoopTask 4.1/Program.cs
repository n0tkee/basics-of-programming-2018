using System;

namespace ifTask4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //rnd.NextDouble();

            Console.WriteLine("Ohjelma tulostaa 10 arvottua kokonaislukua ja niiden neliöjuuret");
            Console.WriteLine("#\tRND\tSQRT");

            int rndNumber;

            Random rnd = new Random();
            rndNumber = rnd.Next(0, 100);

            for (int i = 0; i < 10; i++)
            {
                //rndNumber = rnd.Next(0, 100);
                Console.WriteLine($"{i + 1}.\t{rndNumber}\t{Math.Sqrt(rndNumber)}");

            }
            Console.ReadKey();
        } 
    }
}
