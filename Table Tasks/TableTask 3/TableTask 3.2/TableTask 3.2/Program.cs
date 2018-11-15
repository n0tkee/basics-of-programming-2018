using System;

namespace TableTask_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int[,] arrayValue = new int[10, 20];
            Random rnd = new Random();
            int [] arrayRnd = new int [200];

            for(int i = 0; i < arrayRnd.Length; i++)
            {
                arrayRnd[i] = rnd.Next(0, 200);
                arrayValue[0, 0]++;

                Console.WriteLine("[{0}] = {1}", arrayValue[0,0], arrayRnd[i].ToString("D2"));
            }
            Console.ReadKey();
        }
    }
}
