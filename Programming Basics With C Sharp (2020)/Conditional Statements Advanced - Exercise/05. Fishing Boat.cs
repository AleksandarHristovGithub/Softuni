using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Fishing_Boat





{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fishermen = double.Parse(Console.ReadLine());

            double springShip = 3000;
            double summerAndAutumnShip = 4200;
            double winterShip = 2600;

            double price = 0;
            if (season == "Spring")
            {
                price += springShip;
                if (fishermen <= 6)
                {
                    price -= price * 0.10;
                }
                if (fishermen >= 7 && fishermen <= 11)
                {
                    price -= price * 0.15;
                }
                if (fishermen > 12)
                {
                    price -= price * 0.25;
                }
                if (fishermen % 2 == 0)
                {
                    price -= price * 0.05;
                }
                if (price <= budget)
                {
                    Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
                }
            }
            if (season == "Summer" || season == "Autumn")
            {
                price += summerAndAutumnShip;
                if (fishermen <= 6)
                {
                    price -= price * 0.10;
                }
                if (fishermen >= 7 && fishermen <= 11)
                {
                    price -= price * 0.15;
                }
                if (fishermen > 12)
                {
                    price -= price * 0.25;
                }
                if (fishermen % 2 == 0 && season != "Autumn")
                {
                    price -= price * 0.05;
                }
                if (price <= budget)
                {
                    Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
                }
            }
            if (season == "Winter")
            {
                price += winterShip;
                if (fishermen <= 6)
                {
                    price -= price * 0.10;
                }
                if (fishermen >= 7 && fishermen <= 11)
                {
                    price -= price * 0.15;
                }
                if (fishermen > 12)
                {
                    price -= price * 0.25;
                }
                if (fishermen % 2 == 0)
                {
                    price -= price * 0.05;
                }
                if (price <= budget)
                {
                    Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
                }
            }
        }
    }
}