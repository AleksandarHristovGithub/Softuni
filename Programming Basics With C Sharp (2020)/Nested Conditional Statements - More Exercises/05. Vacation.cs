using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Vacation









{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Camp - {budget * 0.65:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Camp - {budget * 0.45:F2}");
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {

                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Hut - {budget * 0.80:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Hut - {budget * 0.60:F2}");
                }
            }
            else if (budget > 3000)
            {

                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Hotel - {budget * 0.90:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Hotel - {budget * 0.90:F2}");
                }
            }
        }
    }
}

