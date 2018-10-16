using System;

namespace LoopTask_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi nopanheittoa 1000 kertaa\nja tulostaa lisäksi kuutosen esiintymiskertojen lukumäärän:");

            int rndNumber;
            int kutonen = 0;

            Random rnd = new Random();
            rndNumber = rnd.Next(0, 6);

            for (int i = 0; i < 1000; i++)
            {
                rndNumber = rnd.Next(1, 7);

                if (rndNumber == 6)
                {
                    kutonen++;
                }
                Console.WriteLine($"{i + 1}.\t{rndNumber}");
            }
            Console.WriteLine("Kuutonen esiintyi {0} kertaa", kutonen);
            Console.ReadKey();
        }
    }
}
