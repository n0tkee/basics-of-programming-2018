using System;

namespace LoopTask_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma, joka tulostaa N! kertoman arvon");

            Console.Write("Syötä luku: ");
            int num = int.Parse(Console.ReadLine());
            int f = 1;

            if (num<0)
            { Console.WriteLine("Määrittelemätön");
            }

            else
            {
                for (int i = 1; i <= num; i++)
                {
                    f = f * i;
                }
                Console.WriteLine($"N! kertoma on: {f}");
            }
            Console.ReadKey();

        }
    }
}
