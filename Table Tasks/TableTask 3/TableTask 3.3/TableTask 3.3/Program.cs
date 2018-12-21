using System;

namespace TableTask_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t01 02 03 04 05 06 07 08 09 10");
            Console.WriteLine("\t-----------------------------");

            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            Random rnd = new Random();

            for(int i = 0; i < arrT_1.Length; i++)
            {
                arrT_1[i] = rnd.Next(0, 40);
            }

            for (int i = 0; i < arrT_2.Length; i++)
            {
                arrT_2[i] = rnd.Next(0, 40);
            }

            for(int i = 0; i < arrT_3.Length; i++)
            {
                if (arrT_1[i] > arrT_2[i])
                {
                    arrT_3[i] = arrT_1[i];
                }

                else
                {
                    arrT_3[i] = arrT_2[i];
                }
            }


            Console.Write("arrT_1: ");
            foreach (int item in arrT_1)
            {
                Console.Write("{0} ", item.ToString("D2"));
            }

            Console.WriteLine();
            Console.Write("arrT_2: ");
            foreach (int item in arrT_2)
            {
                Console.Write("{0} ", item.ToString("D2"));
            }

            Console.WriteLine();
            Console.Write("arrT_3: ");
            foreach (int item in arrT_3)
            {
                Console.Write("{0} ", item.ToString("D2"));
            }



            Console.ReadKey();
        }
    }
}
