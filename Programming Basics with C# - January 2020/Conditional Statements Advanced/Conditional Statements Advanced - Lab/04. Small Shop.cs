using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Small_Shop





{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.50);
                }
                if (product == "water")
                {
                    Console.WriteLine(amount * 0.80);
                }
                if (product == "beer")
                {
                    Console.WriteLine(amount * 1.20);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(amount * 1.45);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(amount * 1.60);
                }
            }
            if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.40);
                }
                if (product == "water")
                {
                    Console.WriteLine(amount * 0.70);
                }
                if (product == "beer")
                {
                    Console.WriteLine(amount * 1.15);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(amount * 1.30);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(amount * 1.50);
                }
              
            }
            if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.45);
                }
                if (product == "water")
                {
                    Console.WriteLine(amount * 0.70);
                }
                if (product == "beer")
                {
                    Console.WriteLine(amount * 1.10);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(amount * 1.35);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(amount * 1.55);
                }
            }
        }
    }
}