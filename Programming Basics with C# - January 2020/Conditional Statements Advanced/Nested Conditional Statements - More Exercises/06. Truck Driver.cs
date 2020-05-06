using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Truck_Driver









{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double KM = double.Parse(Console.ReadLine());

            if (KM <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    double money = KM * 0.75;
                    double monthsMoney = money * 4;
                    double taxes = monthsMoney - (monthsMoney * 0.10);
                    Console.WriteLine($"{taxes:F2}");
                }
                if (season == "Summer")
                {
                    double money = KM * 0.90;
                    double monthsMoney = money * 4;
                    double taxes = monthsMoney - (monthsMoney * 0.10);
                    Console.WriteLine($"{taxes:F2}");
                }
                if (season == "Winter")
                {
                    double money = KM * 1.05;
                    double monthsMoney = money * 4;
                    double taxes = monthsMoney - (monthsMoney * 0.10);
                    Console.WriteLine($"{taxes:F2}");
                }
            }
            else if (KM > 5000 && KM <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    double money = KM * 0.95;
                    double monthsMoney = money * 4;
                    double taxes = monthsMoney - (monthsMoney * 0.10);
                    Console.WriteLine($"{taxes:F2}");
                }
                if (season == "Summer")
                {
                    double money = KM * 1.10;
                    double monthsMoney = money * 4;
                    double taxes = monthsMoney - (monthsMoney * 0.10);
                    Console.WriteLine($"{taxes:F2}");
                }
                if (season == "Winter")
                {
                    double money = KM * 1.25;
                    double monthsMoney = money * 4;
                    double taxes = monthsMoney - (monthsMoney * 0.10);
                    Console.WriteLine($"{taxes:F2}");
                }
            }
            else if (KM > 10000 && KM <= 20000)
            {
                if (season == "Spring" || season == "Autumn" || season == "Winter" || season == "Summer")
                {
                    double money = KM * 1.45;
                    double monthsMoney = money * 4;
                    double taxes = monthsMoney - (monthsMoney * 0.10);
                    Console.WriteLine($"{taxes:F2}");
                }

            }
        }
    }
}