using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Ski_Trip





{
    class Program
    {
        static void Main(string[] args)
        {


            double days = double.Parse(Console.ReadLine());
            string place = Console.ReadLine();
            string positiveOrFalse = Console.ReadLine();

            double totalPrice = 0;

            double room = 18;
            double apartment = 25;
            double presidental = 35;

            if (place == "room for one person")
            {
                if (days < 10)
                {
                    totalPrice += (days - 1) * room;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice += (days - 1) * room;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
                else if (days > 15)
                {
                    totalPrice += (days - 1) * room;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
            }
            else if (place == "apartment")
            {
                if (days < 10)
                {
                    totalPrice += (days - 1) * apartment;
                    totalPrice -= totalPrice * 0.30;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
                if (days >= 10 && days <= 15)
                {
                    totalPrice += (days - 1) * apartment;
                    totalPrice -= totalPrice * 0.35;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }

                if (days > 15)
                {
                    totalPrice += (days - 1) * apartment;
                    totalPrice -= totalPrice * 0.50;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
            }

            else if (place == "president apartment")
            {
                if (days < 10)
                {
                    totalPrice += (days - 1) * presidental;
                    totalPrice -= totalPrice * 0.10;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
                if (days >= 10 && days <= 15)
                {
                    totalPrice += (days - 1) * presidental;
                    totalPrice -= totalPrice * 0.15;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }

                if (days > 15)
                {
                    totalPrice += (days - 1) * presidental;
                    totalPrice -= totalPrice * 0.20;
                    if (positiveOrFalse == "positive")
                    {
                        totalPrice += totalPrice * 0.25;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    if (positiveOrFalse == "negative")
                    {
                        totalPrice -= totalPrice * 0.10;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
            }
        }
    }
}

