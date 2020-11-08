using System;
namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            int freeBelts = countOfStudents / 6;

            double lighstaberPriceTotal = priceOfLightsaber * (Math.Ceiling(countOfStudents + (countOfStudents * 0.10)));
            double robePriceTotal = priceOfRobes * countOfStudents;
            double beltPriceTotal = priceOfBelts * (countOfStudents - freeBelts);

            double TotalPrice = lighstaberPriceTotal + robePriceTotal + beltPriceTotal;

            if (amountOfMoney >= TotalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {TotalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {TotalPrice - amountOfMoney:F2}lv more.");
            }

        }
    }
}