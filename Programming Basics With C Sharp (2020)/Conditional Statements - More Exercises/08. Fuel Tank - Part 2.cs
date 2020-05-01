using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Fuel_Tank_Part_Two





{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            if (typeOfFuel == "Gas")
            {
                if (clubCard == "Yes")
                {
                    double discountForGas = 0.93 - 0.08;
                    double total = discountForGas * amount;
                    if (amount < 20)
                    {
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    if (amount >= 20 && amount <= 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.08);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                    if (amount > 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.10);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    double total = 0.93 * amount;
                    if (amount < 20)
                    {
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    if (amount >= 20 && amount <= 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.08);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                    if (amount > 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.10);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                }
            }
            if (typeOfFuel == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    double discountForGas = 2.22 - 0.18;
                    double total = discountForGas * amount;
                    if (amount < 20)
                    {
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    if (amount >= 20 && amount <= 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.08);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                    if (amount > 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.10);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    double total = 2.22 * amount;
                    if (amount < 20)
                    {
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    if (amount >= 20 && amount <= 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.08);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                    if (amount > 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.10);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                }
            }
            if (typeOfFuel == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    double discountForGas = 2.33 - 0.12;
                    double total = discountForGas * amount;
                    if (amount < 20)
                    {
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    if (amount >= 20 && amount <= 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.08);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                    if (amount > 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.10);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    double total = 2.33 * amount;
                    if (amount < 20)
                    {
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    if (amount >= 20 && amount <= 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.08);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                    if (amount > 25)
                    {
                        double discountForLitersTwenty = total - (total * 0.10);
                        Console.WriteLine($"{discountForLitersTwenty:F2} lv.");
                    }
                }
            }
        }
    }
}