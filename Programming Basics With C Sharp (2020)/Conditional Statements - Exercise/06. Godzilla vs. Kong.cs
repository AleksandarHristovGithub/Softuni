using System;

namespace Godzilla_vs_Kong




{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            double numberOfStatists = double.Parse(Console.ReadLine());
            double priceOfOutfit = double.Parse(Console.ReadLine());
            if (numberOfStatists < 150)
            {
                double sumOfDecoration = budgetMovie * 0.10;
                double sumOutfit = numberOfStatists * priceOfOutfit;
                double totalSumForMovie = sumOfDecoration + sumOutfit;
                double moneyLeft = budgetMovie - totalSumForMovie;
                if (budgetMovie < totalSumForMovie)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {Math.Abs(budgetMovie - totalSumForMovie):F2} leva more.");
                }
                else
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
                }
            }
            else if (numberOfStatists >= 150)
            {
                double sumOfDecoration = budgetMovie * 0.10;
                double sumOutfit = numberOfStatists * priceOfOutfit;
                double discountOfOutfit = sumOutfit - sumOutfit * 0.10;
                double totalSumForMovie = sumOfDecoration + discountOfOutfit;
                double moneyLeft = budgetMovie - totalSumForMovie;
                if (budgetMovie < totalSumForMovie)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {Math.Abs(budgetMovie - totalSumForMovie):F2} leva more.");
                }
                else
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
                }
            }
        }
    }
}