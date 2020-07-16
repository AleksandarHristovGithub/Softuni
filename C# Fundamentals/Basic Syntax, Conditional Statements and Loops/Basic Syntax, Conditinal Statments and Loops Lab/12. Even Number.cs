using System;

namespace Even_Number



{
    class Program
    {
        static void Main(string[] args)
        {
            test:
            int evenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < 100; i++)
            {

                if (evenNumber % 2 != 0)
                {

                    Console.WriteLine("Please write an even number.");
                    goto test;
                }
                if (evenNumber % 2 == 0)
                {
                    Console.WriteLine("The number is: " + Math.Abs(evenNumber));
                    break;
                }
            }
        }
    }
}