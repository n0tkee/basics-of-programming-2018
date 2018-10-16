using System;

namespace LoopTask_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkausen rivin:");

            int koti = 1;
            int vieras = 2;
            char tasuri = 'x';
            int i = 0;
            double rndNumber;

            for (i = 0; i < 13; i++)
            {
                Random rnd = new Random();
                rndNumber = rnd.NextDouble();

                if (rndNumber < 0.4)
                {
                    Console.WriteLine($"{i + 1}. {koti}");
                }
                else if (rndNumber > 0.6)
                {
                    Console.WriteLine($"{i + 1}. {tasuri}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {vieras}");
                }
            }
            Console.ReadKey();

        } 
    }
}
