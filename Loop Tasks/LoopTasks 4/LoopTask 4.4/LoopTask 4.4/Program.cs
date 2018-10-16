using System;

namespace LoopTask_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi rahan heittoa seuraavasti:\nOhjelma kysyy ensin heittojen lukumäärää ja lopuksi tulostaa saatujen klaavojen ja kruunien määrän.");

            Console.Write("Syötä heittojen lukumäärä: ");
            int lkm = int.Parse(Console.ReadLine());

            int rndNumber;
            int klaava = 0;
            int kruuna = 0;
            int i = 0;

            for (i = 0; i < lkm; i++)
            {
                Random rnd = new Random();
                rndNumber = rnd.Next(0,2);

                if (rndNumber == 1)
                    {
                    kruuna++;
                }
                else
                {
                    klaava++;
                }

            } Console.WriteLine("Heitit {0} kertaa", lkm);
              Console.WriteLine("Kruuna tuli {0} kertaa", kruuna);
              Console.WriteLine("Klaava tuli {0} kertaa", klaava);

            Console.ReadKey();

        }
    }
}
