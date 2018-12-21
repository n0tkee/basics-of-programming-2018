using System;

namespace TableTask_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayRnd = new int[10, 20];
            Random rnd = new Random();

            for(int c = 0; c < arrayRnd.GetUpperBound(0); c++)
            {
                for (int r = 0; r < arrayRnd.GetUpperBound(1); r++)
                {

                    arrayRnd[c, r] = rnd.Next(10, 200);

                    Console.WriteLine($"[{c},{r}] = {arrayRnd[c,r].ToString("D2")}");
                }
            }
            Console.ReadKey();
        }
    }
}
