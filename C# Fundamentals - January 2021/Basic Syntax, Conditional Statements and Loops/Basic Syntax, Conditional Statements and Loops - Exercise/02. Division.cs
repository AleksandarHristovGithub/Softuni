using System;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Division




{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int divisibleNumber = int.Parse(Console.ReadLine());
            if (divisibleNumber % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");

            }
            else if (divisibleNumber % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (divisibleNumber % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (divisibleNumber % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (divisibleNumber % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}