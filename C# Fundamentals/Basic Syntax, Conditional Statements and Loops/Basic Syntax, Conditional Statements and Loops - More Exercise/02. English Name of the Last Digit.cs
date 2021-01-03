using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;

namespace EnglishLastDigit




{
    public class Startup
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Int32 lastNumber = number % 10;

            if (lastNumber == 0)
            {

                Console.WriteLine("zero");
            }
            if (lastNumber == 1)
            {
                Console.WriteLine("one");
            }
            if (lastNumber == 2)
            {
                Console.WriteLine("two");
            }
            if (lastNumber == 3)
            {
                Console.WriteLine("three");
            }
            if (lastNumber == 4)
            {
                Console.WriteLine("four");
            }
            if (lastNumber == 5)
            {
                Console.WriteLine("five");
            }
            if (lastNumber == 6)
            {
                Console.WriteLine("six");
            }
            if (lastNumber == 7)
            {
                Console.WriteLine("seven");
            }
            if (lastNumber == 8)
            {
                Console.WriteLine("eight");
            }
            if (lastNumber == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}