using System;

namespace Looptask_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma, joka tulostaa N! kertoman arvon");

            Console.Write("Syötä luku: ");
            int num = int.Parse(Console.ReadLine());
            int f = 0;

            if (num < 0)
            {
                for (int i = 0; i >= num; i--)
                {
                    f = (f) + (i);
                }
                Console.WriteLine($"N! kertoma on: {f}");
            }

            else
            {
                for (int i = 1; i <= num; i++)
                {
                    f = f + i;
                }
                Console.WriteLine($"N! kertoma on: {f}");
            }
            Console.ReadKey();
        }
    }
}