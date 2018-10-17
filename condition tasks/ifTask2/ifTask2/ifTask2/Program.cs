using System;

namespace ifTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma antaa alennuksesi määrän ja laskee lippusi loppu summan.\nVastaa kysymyksiin (t) jos väite on tosi ja (f) jos väite on epätosi");

            int ticket = 16;
            double varusm = 0.5;
            double opisk = 0.45;
            double opiskMtk = 0.60;
            double Mtk = 0.15;
            double eläk = 0.5;

            Console.Write("Oletko varusmies? ");
            char quest1 = Console.ReadKey().KeyChar;

            if (quest1 == 't')
            {
                Console.WriteLine("\nAlennukesesi on:" + varusm * 100 + "%");
                Console.WriteLine("Lippusi hinta on:" + varusm * ticket + "e");
                Console.ReadKey();
            }

            else if (quest1 == 'f')
            {
                Console.Write("\nOletko opiskelija? ");
                char quest2 = Console.ReadKey().KeyChar;

                if (quest2 == 't')
                {
                    Console.Write("\nOletko myös MTK-jäsen? ");
                    char quest3 = Console.ReadKey().KeyChar;

                    if (quest3 == 't')
                    {
                        Console.WriteLine("\nAlennukesesi on:" + opiskMtk * 100 + "%");
                        Console.WriteLine("Lippusi hinta on:" + opiskMtk * ticket + "e");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.WriteLine("\nAlennukesesi on:" + opisk * 100 + "%");
                        Console.WriteLine("Lippusi hinta on:" + opisk * ticket + "e");
                        Console.ReadKey();
                    }
                }
                else if (quest2 == 'f')
                {
                    Console.Write("\nSyötä ikäsi? ");
                    int age = int.Parse (Console.ReadLine());

                    if (age < 7)
                    {
                        Console.WriteLine("\nPääset ilmaiseksi!");
                        Console.ReadKey();
                    }

                    else if (age > 65)
                    {
                        Console.WriteLine("\nAlennukesesi on:" + eläk * 100 + "%");
                        Console.WriteLine("Lippusi hinta on:" + eläk * ticket + "e");
                        Console.ReadKey();
                    }

                    else 
                    {
                        Console.Write("\nOletko MTK-jäsen? ");
                        char quest4 = Console.ReadKey().KeyChar;

                        if (quest4 == 't')
                        {
                            Console.WriteLine("\nAlennukesesi on:" + Mtk * 100 + "%");
                            Console.WriteLine("Lippusi hinta on:" + Mtk * ticket + "e");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine("\nValitettavasti ette saa alennusta.");
                            Console.WriteLine("Lippusi hinta on:" + ticket + "e");
                            Console.ReadKey();
                        }
                    }
                } Console.ReadKey();
            }
        }
    }
}


