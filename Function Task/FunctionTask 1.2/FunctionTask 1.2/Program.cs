using System;

namespace FunctionTask_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa annetuista luvuista pienemmän");
            Console.WriteLine("\n");

            Console.WriteLine("Syötä luku: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä luku: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Luku " + getMin(num1, num2) + " on pienempi kuin " + getMax(num1, num2));
            Console.ReadKey();
        }

        public static int getMin(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public static int getMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
