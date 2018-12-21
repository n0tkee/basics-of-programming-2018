using System;

namespace Tabletask_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();

            Console.WriteLine("[X] = Arvo");

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,20);
                Console.WriteLine($"[{i+1}] = {array[i].ToString("D2")}");

            }
            Console.ReadKey();
        }
    }
}
