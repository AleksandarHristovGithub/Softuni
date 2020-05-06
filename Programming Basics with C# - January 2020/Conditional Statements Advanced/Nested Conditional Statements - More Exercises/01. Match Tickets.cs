using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Match_Tickets





{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string normalOrVip = Console.ReadLine();
            double numberOfPeople = double.Parse(Console.ReadLine());

            double total = 0;
            double priceCut = 0;
            if (normalOrVip == "Normal")
            {
                if (numberOfPeople <= 4)
                {
                    double budgetCut = budget - (budget * 0.75);
                    double ticketPriceCut = 249.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                else if (numberOfPeople >= 5 && numberOfPeople <= 9)
                {
                    double budgetCut = budget - (budget * 0.60);
                    double ticketPriceCut = 249.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                else if (numberOfPeople >= 10 && numberOfPeople <= 24)
                {
                    double budgetCut = budget - (budget * 0.50);
                    double ticketPriceCut = 249.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                else if (numberOfPeople >= 25 && numberOfPeople <= 49)
                {
                    double budgetCut = budget - (budget * 0.40);
                    double ticketPriceCut = 249.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                else if (numberOfPeople >= 50)
                {
                    double budgetCut = budget - (budget * 0.25);
                    double ticketPriceCut = 249.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                if (priceCut > total)
                {
                    Console.WriteLine($"Yes! You have {priceCut - total:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(total - priceCut):F2} leva.");
                }
            }

            else if (normalOrVip == "VIP")
            {
                if (numberOfPeople <= 4)
                {
                    double budgetCut = budget - (budget * 0.75);
                    double ticketPriceCut = 499.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                else if (numberOfPeople >= 5 && numberOfPeople <= 9)
                {
                    double budgetCut = budget - (budget * 0.60);
                    double ticketPriceCut = 499.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                else if (numberOfPeople >= 10 && numberOfPeople <= 24)
                {
                    double budgetCut = budget - (budget * 0.50);
                    double ticketPriceCut = 499.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                else if (numberOfPeople >= 25 && numberOfPeople <= 49)
                {
                    double budgetCut = budget - (budget * 0.40);
                    double ticketPriceCut = 499.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                else if (numberOfPeople >= 50)
                {
                    double budgetCut = budget - (budget * 0.25);
                    double ticketPriceCut = 499.99 * numberOfPeople;
                    priceCut += budgetCut;
                    total += ticketPriceCut;
                }
                if (priceCut > total)
                {
                    Console.WriteLine($"Yes! You have {priceCut - total:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(total - priceCut):F2} leva.");
                }
            }
        }
    }
}
