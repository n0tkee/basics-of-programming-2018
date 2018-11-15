using System;

namespace Tabletask_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int[] arrayValue = new int[10];

            Console.WriteLine("[X] = Arvo");

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,20);
                arrayValue[0]++;
                Console.WriteLine("[{0}] = {1}", arrayValue[0], array[i].ToString("D2"));

            }
            Console.ReadKey();
        }
    }
}
