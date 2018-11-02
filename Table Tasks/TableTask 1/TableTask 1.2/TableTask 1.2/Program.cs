using System;

namespace TableTask_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rndNumber = 0;
            int ordinalNum = 0;
            int sum = 0;

            Random rnd = new Random();
            int[] rndNumberList = new int[100];

            for (int i = 0; i < rndNumberList.Length; i++)
            {
                rndNumber = rnd.Next(0, 50);
                rndNumberList[i] = rndNumber;
                sum += rndNumber;
                ordinalNum++;

                Console.WriteLine($"{ordinalNum}." + rndNumber);
            }
            Console.WriteLine("Ka.= " + (sum / rndNumberList.Length));
            Console.ReadKey();
        }


        //VAIHTOEHTO 2 
        //static void Main(string[] args)
        //{ 
        //    rndNumberList(0, 50, 100);
        //    Console.ReadKey();
        //}
        //static int rndNumberList(int min, int max, int numAmount)
        //{
        //    Random rnd = new Random();
        //    int sum = 0;
        //    int ordinalNum = 1;
        //    for (int i = 0; i < numAmount; i++)
        //    {
        //        int rndNumber = rnd.Next(min, max);
        //        sum += rndNumber;
        //        Console.WriteLine($"{ordinalNum}. " + rndNumber);
        //        ordinalNum++;
        //    }
        //    Console.WriteLine("");
        //    Console.WriteLine("Ka. = " + sum/numAmount);

        //    return 0;
        //}
    }
}

