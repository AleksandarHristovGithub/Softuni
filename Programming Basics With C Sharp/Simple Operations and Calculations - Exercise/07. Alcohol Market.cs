
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
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakijaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double winePrice = (whiskeyPrice / 2) - (0.4 * (whiskeyPrice / 2));
            double beerPrice = (whiskeyPrice / 2) - (0.8 * (whiskeyPrice / 2));
            double sumOfRakija = rakijaLiters * (whiskeyPrice / 2);
            double sumOfWine = wineLiters * winePrice;
            double sumOfBeer = beerPrice * beerLiters;
            double sumOfWhiskey = whiskeyLiters * whiskeyPrice;
            Console.WriteLine($"{sumOfRakija + sumOfWine + sumOfBeer + sumOfWhiskey:F2}");
        }
    }
}