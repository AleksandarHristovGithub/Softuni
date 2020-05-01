using System;

namespace Toy_Shop



{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfTrip = double.Parse(Console.ReadLine());
            double numberOfPuzzles = double.Parse(Console.ReadLine());
            double numberOfTalkingDolls = double.Parse(Console.ReadLine());
            double numberOfTeddyBears = double.Parse(Console.ReadLine());
            double numberOfMinions = double.Parse(Console.ReadLine());
            double numberOfTrucks = double.Parse(Console.ReadLine());

            double sum = numberOfPuzzles * 2.60 + numberOfTalkingDolls * 3 + numberOfTeddyBears * 4.10 + numberOfMinions * 8.20 + numberOfTrucks * 2;
            double toySum = numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;
            if (toySum >= 50)
            {
                double discount = sum - 0.25 * sum;
                double rent = discount - discount * 0.10;
                if (rent >= priceOfTrip)
                {
                    Console.WriteLine($"Yes! {rent - priceOfTrip:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Math.Abs(rent - priceOfTrip):F2} lv needed.");
                }
            }
            else
            {
                double discount = sum - 0.10 * sum;

                if (discount >= priceOfTrip)
                {
                    Console.WriteLine($"Yes! {discount - priceOfTrip:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Math.Abs(discount - priceOfTrip):F2} lv needed.");
                }
            }
        }
    }
}
