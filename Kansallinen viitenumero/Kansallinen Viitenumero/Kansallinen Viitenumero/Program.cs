using System;
using System.IO;

namespace Kansallinen_Viitenumero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("National Reference Number\n");
                Console.WriteLine("This program has three different functions:");
                Console.WriteLine("1. Check the national reference number");
                Console.WriteLine("2. Generate a single national reference number");
                Console.WriteLine("3. Generate multiple national reference numbers");

                Console.Write("\nChoose the function[1-3]: ");

                int userChoice = int.Parse(Console.ReadLine());

                if( userChoice > 3 || userChoice < 1)
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                }
                else if (userChoice == 1)
                {
                    RefnumberCheck();
                }
                else if (userChoice == 2)
                {
                    IndividualRefenceNumberCreator();

                }
                else if (userChoice == 3)
                {
                    ReferenceNumberCreator();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        static void RefnumberCheck()
        {
            try
            {
                Console.Write("\nEnter the reference number: ");
                string userInput = Console.ReadLine();
                string userInputClean = userInput.Replace(" ", "").Replace("-", "");
                string checkNum1 = userInputClean.Substring(userInputClean.Length - 1, 1);
                string baseRefNum = userInputClean.Remove(userInputClean.Length - 1);

                int sum = 0;
                int[] multiplier = { 7, 3, 1 };
                int multiplierIndex = 0;

                for (int i = baseRefNum.Length - 1; i >= 0; i--)
                {
                    sum += multiplier[multiplierIndex++] * int.Parse(baseRefNum.Substring(i, 1));
                    if (multiplierIndex >= multiplier.Length)
                    {
                        multiplierIndex = 0;
                    }
                }
                string checkNum2 = baseRefNum + ((10 - sum % 10) % 10).ToString();
                string checknum3 = ((10 - sum % 10) % 10).ToString();
                if (userInput == checkNum2)
                {
                    string userInputCorrect = userInput;
                    userInputCorrect = userInputCorrect.Insert(3, " ");
                    Console.WriteLine($"{userInputCorrect} - OK");
                }
                else
                {
                    Console.WriteLine("Incorrect reference number!");
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        static void IndividualRefenceNumberCreator()
        {
            try
            {
                Console.Write("\nEnter the basepart of the reference number: ");
                string userReferenceNum = Console.ReadLine();

                if (userReferenceNum.Length <= 3 || userReferenceNum.Length >= 19)
                {
                    Console.WriteLine("Incorrect reference number!");
                }
                else
                {
                    Console.Write("Created reference number: ");
                    int sum = 0;
                    int[] multiplier = { 7, 3, 1 };
                    int multiplierIndex = 0;
                    for (int i = userReferenceNum.Length - 1; i >= 0; i--)
                    {
                        sum += multiplier[multiplierIndex++] * int.Parse(userReferenceNum.Substring(i, 1));
                        if (multiplierIndex >= multiplier.Length)
                        {
                            multiplierIndex = 0;
                        }
                    }
                    int checkNumber = (10 - sum % 10) % 10;
                    int createdReferenceNumber = int.Parse(userReferenceNum + checkNumber);
                    string createdReferenceNumber1 = createdReferenceNumber.ToString();
                    createdReferenceNumber1 = createdReferenceNumber1.Insert(3, " ");
                    Console.WriteLine(createdReferenceNumber1);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        static void ReferenceNumberCreator()
        {

            try
            {
                Console.Write("\nEnter the reference number basepart: ");
                int userReferenceNum = int.Parse(Console.ReadLine());
                Console.Write("Amount of reference numbers: ");
                int refNumAmount = int.Parse(Console.ReadLine());
                string userReferenceNum2 = userReferenceNum.ToString();

                if (userReferenceNum2.Length <= 3 || userReferenceNum2.Length >= 19)
                {
                    Console.WriteLine("Incorrect reference number");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nCounted reference numbers");

                    for (int c = 0; c < refNumAmount; c++)
                    {
                        string userReferenceNum1 = userReferenceNum.ToString();
                        //this intiger will randomize the reference number generation
                        int randomizer = 1 + c;

                        string rndNum = randomizer.ToString();
                        string refereneceNumGenerator = userReferenceNum + rndNum;

                        int sum = 0;
                        int[] multiplier = { 7, 3, 1 };
                        int multiplierIndex = 0;
                        for (int i = refereneceNumGenerator.Length - 1; i >= 0; i--)
                        {
                            sum += multiplier[multiplierIndex++] * int.Parse(refereneceNumGenerator.Substring(i, 1));
                            if (multiplierIndex >= multiplier.Length)
                            {
                                multiplierIndex = 0;
                            }
                        }
                        int checkNumber = (10 - sum % 10) % 10;
                        int createdReferenceNumber = int.Parse(refereneceNumGenerator + checkNumber);
                        string createdReferenceNumber1 = createdReferenceNumber.ToString();
                        createdReferenceNumber1 = createdReferenceNumber1.Insert(3, " ");
                        Console.WriteLine(createdReferenceNumber1);

                    }
                    //TIEDOSTOON TALLENTAMINEN EI ONNISTU KOSKA KOMENTO TÄYTYISI OLLA FOR SILMUKAN SISÄLLÄ, KOKO OHJELMA PITÅISI PERIAATTEESSA
                    //TEHDÄ ERI TAVALLA JOS HALUAA TALLENNUKSEN TOIMIMAAN
                    //string path = @"C:\TEMP\REFERENCENUMBERS.txt";
                    //WriteToFile(path, createdReferenceNumber.ToString());
                    //Console.WriteLine("Reference numbers file created! Check the file: C:/TEMP/REFERENCENUMBERS.tx");

                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();            }
        }

        static void WriteToFile(string filePath, string data)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Created reference numbers:");
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine($"{data}");
            }
          
        }
    }
}
