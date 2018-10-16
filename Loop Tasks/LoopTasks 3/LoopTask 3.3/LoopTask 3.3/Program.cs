using System;

namespace Looptask_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen lukujen summan");

            Console.Write("Syötä N! arvo: ");
            int num = int.Parse(Console.ReadLine());
            int f = 0;
            int oddSum = 0;
            int evenSum = 0;

            if (num < 0)
            {
                Console.WriteLine("Määrittelemätön");
            }

            {
                for (int i = 1; i <= num; i++)
                {
                    f = f + i;

                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + i;
                    }
                    else
                    {
                        oddSum = oddSum + i;
                    }
                }
                Console.WriteLine($"Parillisten summa on: {evenSum}");
                Console.WriteLine($"Parittoimien summa on: {oddSum}");
                Console.ReadKey();
            }
        }
    }
}

