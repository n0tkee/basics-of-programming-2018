using System;

namespace FunctionTask_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa annetun määrän tähtiä!");

            int n;
            while (true)
            {
                Console.Write("Tähtien lukumäärä: \n");
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("Luku {0} ei ole sallittu luku", n);
                }
                else
                {
                    break;
                }
            }
            string asterisks = getStars(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();

        }
        static string getStars(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res;
        }
    }
}
