using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKGVegetable = double.Parse(Console.ReadLine());
            double priceKGFruits = double.Parse(Console.ReadLine());
            double totalKGVegetables = double.Parse(Console.ReadLine());
            double totalKGFruits = double.Parse(Console.ReadLine());

            double priceVegetable = priceKGVegetable * totalKGVegetables;
            double priceFruits = priceKGFruits * totalKGFruits;
            double total = priceVegetable + priceFruits;
            Console.WriteLine($"{total / 1.94:F2}");
        }
    }
}
