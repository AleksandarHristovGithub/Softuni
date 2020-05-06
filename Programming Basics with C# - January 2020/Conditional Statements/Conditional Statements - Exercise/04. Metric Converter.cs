using System;

namespace Metric_Converter



{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string convertOne = Console.ReadLine();
            string convertTwo = Console.ReadLine();
            double finalNum = 0;

            if (convertOne.Equals("mm") && convertTwo.Equals("cm"))
            {
                finalNum = num / 10;
            }
            else if (convertOne.Equals("mm") && convertTwo.Equals("m"))
            {
                finalNum = num / 1000;
            }
            else if (convertOne.Equals("cm") && convertTwo.Equals("mm"))
            {
                finalNum = num * 10;
            }
            else if (convertOne.Equals("cm") && convertTwo.Equals("m"))
            {
                finalNum = num / 100;
            }
            else if (convertOne.Equals("m") && convertTwo.Equals("mm"))
            {
                finalNum = num * 1000;
            }
            else if (convertOne.Equals("m") && convertTwo.Equals("cm"))
            {
                finalNum = num * 100;
            }
            Console.WriteLine($"{finalNum:F3}");
        }
    }
}