using System;

namespace ParcingRomanNumeral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter roman number: ");
            string romanNumber;
            bool isTrue = true;
            while (isTrue) 
            {
                romanNumber = Console.ReadLine().ToUpper();
                if (RomanNumbers.IfCorrectRomanNumber(romanNumber))
                {
                    Console.WriteLine($"Roman numeral = {romanNumber}\nArabic numeral = {RomanNumbers.ParseRomanNumberToNormalNumber(romanNumber)}");
                    isTrue = false;
                }
                else 
                {
                    Console.WriteLine("Incorrect roman number");
                    Console.WriteLine("Enter another roman number");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
