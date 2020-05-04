using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Hotel_Room





{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (days <= 7)
                {
                    Console.WriteLine($"Apartment: {days * 65:F2} lv.");
                    Console.WriteLine($"Studio: {days * 50:F2} lv.");
                }
                if (days > 7 && days <= 14)
                {
                    double discount = days * 50;
                    Console.WriteLine($"Apartment: {days * 65:F2} lv.");
                    Console.WriteLine($"Studio: {discount - (discount * 0.05):F2} lv.");
                }
                if (days > 14)
                {
                    double discountApartment = days * 65;
                    double discountStudio = days * 50;
                    Console.WriteLine($"Apartment: {discountApartment - (discountApartment * 0.10):F2} lv.");
                    Console.WriteLine($"Studio: {discountStudio - (discountStudio * 0.30):F2} lv.");
                }
            }
            if (month == "June" || month == "September")
            {
                if (days <= 14)
                {
                    Console.WriteLine($"Apartment: {days * 68.70:F2} lv.");
                    Console.WriteLine($"Studio: {days * 75.20:F2} lv.");
                }
                if (days > 14)
                {
                    double discountApartment = days * 68.70;
                    double discountStudio = days * 75.20;
                    Console.WriteLine($"Apartment: {discountApartment - (discountApartment * 0.10):F2} lv.");
                    Console.WriteLine($"Studio: {discountStudio - (discountStudio * 0.20):F2} lv.");
                }
            }
            if (month == "July" || month == "August")
            {
                if (days <= 14)
                {
                    Console.WriteLine($"Apartment: {days * 77:F2} lv.");
                    Console.WriteLine($"Studio: {days * 76:F2} lv.");
                }
                if (days > 14)
                {
                    double discountApartment = days * 77;
                    Console.WriteLine($"Apartment: {discountApartment - (discountApartment * 0.10):F2} lv.");
                    Console.WriteLine($"Studio: {days * 76:F2} lv.");
                }
            }
        }
    }
}