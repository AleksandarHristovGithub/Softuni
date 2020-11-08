using System;

namespace Division



{
    class Program
    {
        static void Main(string[] args)
        {
            int divisionNumber = int.Parse(Console.ReadLine());

            if (divisionNumber % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (divisionNumber % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (divisionNumber % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (divisionNumber % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (divisionNumber % 2 == 0)
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