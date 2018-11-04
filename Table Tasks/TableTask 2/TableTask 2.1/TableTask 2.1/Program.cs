using System;

namespace TableTask_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            
            Random rnd = new Random();
            int[] lottoNums = new int[8];

            for (int i = 0; i < lottoNums.Length; i++)
            {

                temp = rnd.Next(0, 39) + 1;
                while (isDup(temp, lottoNums)) 
                {
                    temp = rnd.Next(0, 39) + 1;
                }
                lottoNums[i] = temp;
            }
            Array.Sort(lottoNums);
            //foreach (int item in lottoNums)
            //{
            //    Console.Write("{0}", item);
            //}
            //Console.WriteLine("Loton oikea rivi on:\n{0}", string.Join(", ", lottoNums));

            Console.WriteLine("Loton oikea rivi on:\n{0}, {1}, {2}, {3}, {4}, {5}, {6}", lottoNums[0], lottoNums[1], lottoNums[2], lottoNums[3], lottoNums[4], lottoNums[5], lottoNums[6]);
            Console.WriteLine("Lisänumero: {0}", lottoNums[7]);
            doubleUpNum();
            Console.ReadKey();
        }

        static bool isDup(int temp, int[] lottoNums)
        {
            foreach (var item in lottoNums)
            {
                if(temp == item)
                {
                    return true;
                }
            }
            return false;
        }

        static int doubleUpNum()
        {
            Random num = new Random();
            int duNum = num.Next(0, 39);
            if (duNum == 0)
            {
                duNum++;
            }
            Console.WriteLine("Plussanumero: " + duNum);

            return 0;
        }
    }
}
