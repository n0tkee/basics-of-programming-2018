using System;

namespace ifTask1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma järjestää syötetyt luvut pienimmästä suurempaan");

            int num1, num2, num3;

            Console.WriteLine("Syötä 1. luku");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Syötä 2. luku");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Syötä 3. luku");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Syötit luvut {num1} - {num2} - {num3}");
            Console.WriteLine("..........");

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    if (num2 > num3)
                        Console.WriteLine($"{num3} - {num2} - {num1}");
                }
                if (num1 > num2)
                {
                    if (num3 > num2)
                    {
                        if (num1 > num3)
                            Console.WriteLine($"{num2} - {num3} - {num1}");
                    }
                }
                if (num1 > num2)
                {
                    if (num3 > num2)
                    {
                        if (num3 > num1)

                            Console.WriteLine($"{num2} - {num1} - {num3}");
                    }
                }
            }
            else
            {

                //(num2 > num1)
                //{
                if (num3 > num2)
                {
                    if (num3 > num2)

                        Console.WriteLine($"{num1} - {num2} - {num3}");
                }

                if (num2 > num1)
                {
                    if (num2 > num3)
                    {
                        if (num1 > num3)

                            Console.WriteLine($"{num1} - {num3} - {num2}");
                    }

                }
                if (num2 > num1)
                {
                    if (num2 > num3)
                    {
                        if (num1 > num3)

                            Console.WriteLine($"{num3} - {num1} - {num2}");
                    }
                }
            }
        }
    }
}







