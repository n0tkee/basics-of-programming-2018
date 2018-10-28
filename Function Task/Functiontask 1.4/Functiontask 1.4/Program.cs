using System;

namespace Functiontask_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            numReturn();
            Console.ReadKey();
        }

        static string numReturn()
        {
            int i = 0;
            int ordinalNumber = 1;
            int largest = 0;
            Console.WriteLine("Syötä luku: ");

            for (i = 0; i < 10; ordinalNumber++, i++)
            {
                Console.Write("{0}.", ordinalNumber);
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Luku ei kelpaa, syötä positiivinen luku");
                    i--;
                }

                else if (i == 0)
                {
                    largest = num;

                }

                else
                {
                    if (num > largest)
                        largest = num;
                }
            }
            //int ordinalNumberOfLargest = 
            Console.WriteLine("\n");
            Console.WriteLine("Suurin luku oli: {0}",largest);
            return "";
        }
    }
}