using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Car_To_Go









{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Economy class");
                    Console.WriteLine($"Cabrio - {budget * 0.35:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Economy class");
                    Console.WriteLine($"Jeep - {budget * 0.65:F2}");
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Cabrio - {budget * 0.45:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Jeep - {budget * 0.80:F2}");
                }
            }
            else if (budget > 500)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Luxury class");
                    Console.WriteLine($"Jeep - {budget * 0.90:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Luxury class");
                    Console.WriteLine($"Jeep - {budget * 0.90:F2}");
                }
            }
        }
    }
}