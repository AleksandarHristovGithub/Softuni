using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Trade_Commissions





{
    class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (0 <= amount && amount <= 500)
                {
                    Console.WriteLine($"{amount * 0.05:F2}");
                }
                if (500 < amount && amount <= 1000)
                {
                    Console.WriteLine($"{amount * 0.07:F2}");
                }
                if (1000 < amount && amount <= 10000)
                {
                    Console.WriteLine($"{amount * 0.08:F2}");
                }
                if (amount > 10000)
                {
                    Console.WriteLine($"{amount * 0.12:F2}");
                }

            }
            else if (town == "Varna")
            {
                if (0 <= amount && amount <= 500)
                {
                    Console.WriteLine($"{amount * 0.045:F2}");
                }
                if (500 < amount && amount <= 1000)
                {
                    Console.WriteLine($"{amount * 0.075:F2}");
                }
                if (1000 < amount && amount <= 10000)
                {
                    Console.WriteLine($"{amount * 0.10:F2}");
                }
                if (amount > 10000)
                {
                    Console.WriteLine($"{amount * 0.13:F2}");
                }
            }
            else if (town == "Plovdiv")
            {
                if (0 <= amount && amount <= 500)
                {
                    Console.WriteLine($"{amount * 0.055:F2}");
                }
                if (500 < amount && amount <= 1000)
                {
                    Console.WriteLine($"{amount * 0.08:F2}");
                }
                if (1000 < amount && amount <= 10000)
                {
                    Console.WriteLine($"{amount * 0.12:F2}");
                }
                if (amount > 10000)
                {
                    Console.WriteLine($"{amount * 0.145:F2}");
                }
                if (amount < 0)
                {
                    Console.WriteLine("error");
                }
            }

            else if (town != "Sofia" && town != "Varna" && town != "Plovdiv")
            {
                Console.WriteLine("error");
            }
        }
    }
}