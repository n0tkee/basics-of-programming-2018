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
                Console.WriteLine("Määrittelemätön");
            }

            else 
            {
                for (int i = 1; i <= num; i++)
                {
                    //if (i % 2 ==0)
                    f = f + i;
                    if (i % 2 == 0) ;

                }
                Console.WriteLine($"N! kertoma on: {f}");
            }
        }
    }
}

