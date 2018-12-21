using System;

namespace StringTask_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma luo henkilötunnuksen\n");
            Console.Write("Syötä henkilötunnkusesi alkuosa: ");
            string userInput = Console.ReadLine();

            if (userInput.Length != 6)
            {
                Console.WriteLine("Virheellinen alkuosa!");
                Console.ReadKey();
                return;
            }

            string day = userInput.Substring(0, 2);
            string month = userInput.Substring(2, 2);
            string year = userInput.Substring(4, 2);

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

            Random rnd = new Random();
            int rndNum = rnd.Next(2, 899);

            string endPart = rndNum.ToString();

            if(endPart.Length != 3)
            {
                endPart = endPart.Insert(0, "00");
            }

            string alkuOsa = userInput + endPart;
            int alkuOsa1 = int.Parse(alkuOsa);

            int checkNum = alkuOsa1 % 31;
            //checkNum pitäisi vielä saada muutettua tarkistus merkiksi, eli numerot 10 ylöspäin muuttettaisiin kirjaimiksi.
            //itse en keksi muuta kuin älyttömän pitkän if lauseen
            string checkNum1 = checkNum.ToString();

            //Creating the separator
            Console.WriteLine("Valitse seuraavista vaihtoehdoista [1-2]");
            Console.WriteLine("1. Olen syntynyt 1900-luvulla");
            Console.WriteLine("2. Olen synytyny 2000-luvulla");
            Console.Write("Vastaus: ");
            int vastaus = int.Parse(Console.ReadLine());
            if (vastaus == 1)
            {
                //char separator1 = '-';
                //string separator = separator1.ToString();
                string hetu = userInput + '-' + endPart + checkNum1;
                Console.WriteLine(hetu);
                Console.ReadKey();
            }
            else if (vastaus == 2)
            {
                //char separator1 = '+';
                //string separator = separator1.ToString();
                string hetu = userInput + '+' + endPart + checkNum1;
                Console.WriteLine(hetu);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Virheellinen valinta!");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }
    }
}
