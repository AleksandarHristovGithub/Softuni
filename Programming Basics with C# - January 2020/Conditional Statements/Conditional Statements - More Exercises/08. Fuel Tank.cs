using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Fuel_Tank





{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            if (typeOfFuel == "Diesel")
            {
                if (amount < 25)
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
                else if (amount >= 25)
                {
                    Console.WriteLine("You have enough diesel.");
                }
            }
            else if (typeOfFuel == "Gasoline")
            {
                if (amount < 25)
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
                else if (amount >= 25)
                {
                    Console.WriteLine("You have enough gasoline.");
                }
            }
            else if (typeOfFuel == "Gas")
            {
                if (amount < 25)
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
                else if (amount >= 25)
                {
                    Console.WriteLine("You have enough gas.");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}