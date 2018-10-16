using System;

namespace LoopTask_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1 - 9");

            int i;

            Console.Write("Syötä Luku: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 1) 
            {
                Console.WriteLine("Määrittelemätön");
            }
            else if (num>9)
            {
                Console.WriteLine("Määrittelemätön");

            }
            else
            {
                for (i =1; i <= 9; i++)
                {
                    Console.WriteLine(num + "*" + i + "=" + num * i);
                }
            }
            Console.ReadLine();

        }
    }
}
