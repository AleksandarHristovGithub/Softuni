using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double sweeters = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double gofreti = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            double cakesTotal = cakes * 45;
            double gofretiTotal = gofreti * 5.80;
            double pancakesTotal = pancakes * 3.20;
            double totalSumForADay = (cakesTotal + gofretiTotal + pancakesTotal) * sweeters;
            double totalSumForCampaign = totalSumForADay * days;
            double sumAfterCoveringExpenses = totalSumForCampaign - (totalSumForCampaign / 8);
            Console.WriteLine($"{sumAfterCoveringExpenses:F2}");
        }
    }
}