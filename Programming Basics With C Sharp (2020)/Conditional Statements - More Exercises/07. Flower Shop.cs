using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Flower_Shop





{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfMagnoli = double.Parse(Console.ReadLine());
            double numberOfZumbuli = double.Parse(Console.ReadLine());
            double numberOfRozi = double.Parse(Console.ReadLine());
            double numberOfCatsuses = double.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double sum = numberOfMagnoli * 3.25 + numberOfZumbuli * 4 + numberOfRozi * 3.5 + numberOfCatsuses * 8;
            double taxes = sum - (sum * 0.05);

            double finalFirst = priceOfGift - taxes;
            double finalSecond = taxes - priceOfGift;
            if (taxes >= priceOfGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(Math.Abs(finalSecond))} leva.");
            }
            else if (priceOfGift >= finalFirst)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(finalFirst)} leva.");
            }

        }
    }
}