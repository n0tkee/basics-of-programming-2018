using System;

namespace FunctionTask_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string retNumber = numberFromRange(6, 70);
            Console.WriteLine(retNumber);

            Console.ReadKey();
        }

        public static string numberFromRange(int lowerBound, int upperBound)
        {
            int num;
       
            do
            {
                Console.Write("Syötä luku väliltä 6-70: ");
                num = int.Parse(Console.ReadLine());

                if (num < lowerBound)
                {
                    Console.WriteLine("Luku on liian pieni!\n");
                }
                else if (num > upperBound)
                {
                    Console.WriteLine("Luku on liian suuri!\n");
                }
                else
                {
                    return "";
                }

            }

            while (num > lowerBound || num < upperBound) ;
            return "Syötä uusi luku:";
        }
        
    }
}
