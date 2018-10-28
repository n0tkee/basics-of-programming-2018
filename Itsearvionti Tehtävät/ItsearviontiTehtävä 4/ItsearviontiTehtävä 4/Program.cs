using System;

namespace ItsearviontiTehtävä_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelmalle syötetään kaksi lukua. Ohjelma tulostaa yhteen-, vähennys-, kerto- ja jakolasku näistä luvuista");

            Console.Write("Syötä luku: ");
            double number1 = Double.Parse(Console.ReadLine());

            Console.Write("Syötä luku: ");
            double number2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("\n1.luku: {0:N}", number1);
            Console.WriteLine("2.luku: {0:N}\n", number2);

            double plusResult = Math.Round(number1 + number2, 2);
            double minusResult = Math.Round(number1 - number2, 2);
            double multipleResult = Math.Round(number1 * number2, 2);
            double divisionResult = Math.Round(number1 / number2, 2);

            Console.WriteLine($"{number1} + {number2} =" + plusResult);
            Console.WriteLine($"{number1} - {number2} =" + minusResult);
            Console.WriteLine($"{number1} x {number2} =" + multipleResult);
            Console.WriteLine($"{number1} / {number2} =" + divisionResult);

            Console.ReadKey();

        }
    }
}
