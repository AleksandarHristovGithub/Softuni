using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Journey





{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string summerOrWinter = Console.ReadLine();

            if (budget <= 100)
            {
                if (summerOrWinter == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget * 0.3:F2}");
                }
                else if (summerOrWinter == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget * 0.7:F2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (summerOrWinter == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget * 0.4:F2}");
                }
                else if (summerOrWinter == "winter")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget * 0.8:F2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget * 0.9:F2}");
            }
        }
    }
}