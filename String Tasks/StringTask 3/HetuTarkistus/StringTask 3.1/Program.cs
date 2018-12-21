using System;

namespace StringTask_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa henkilötunnuksen");
            Console.Write("Syötä henkilötunnkusesi: ");
            string userInput = Console.ReadLine();
            HetuTarkastus(userInput);
            Console.ReadKey();
        }
        static void HetuTarkastus(string Data)
        {
            if (Data.Length != 11)
            {
                Console.WriteLine("Virheellinen henkilötunnus!");
                Console.ReadKey();
                return;
            }

            string day = Data.Substring(0, 2);
            string month = Data.Substring(2, 2);
            string year = Data.Substring(4, 2);
            string separator = Data.Substring(6, 1);

            int dayX = int.Parse(day);
            int monthX = int.Parse(month);
            int yearX = int.Parse(year);

            if (dayX > 31 || dayX < 1)
            {
                Console.WriteLine("Väärä päivämäärä!");
            }

            else if (monthX > 12 || monthX < 1)
            {
                Console.WriteLine("Virheellinen kuukausi!");
            }

            else if (yearX > 2018 || yearX < 0)
            {
                Console.WriteLine("Virheellinen vuosi!");
            }
            else if (separator != "-" || separator != "+")
            {
                Console.WriteLine("Virheellinen välimerkki!");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
