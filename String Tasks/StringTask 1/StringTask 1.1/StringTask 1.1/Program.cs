using System;

namespace StringTask_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma ilmoittaa käyttäjän syöttämästä syötteestä merkkien lukumäärän:");
            string hello = Console.ReadLine();
            Console.WriteLine($"Syötteessä on {hello.Length} merkkiä.");
            Console.ReadKey();
        }
    }
}
