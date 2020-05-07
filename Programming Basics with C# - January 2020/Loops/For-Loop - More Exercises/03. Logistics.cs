using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            int goods = 0;

            double pricebus = 0;
            double pricetruck = 0;
            double pricetrain = 0;
            double allgoods = 0;
            double totalpricebus = 0;
            double totalpricetruck = 0;
            double totalpricetrain = 0;
            double buscount = 0;
            double truckcount = 0;
            double traincount = 0;
            for (int i = 0; i < n; i++)
            {
                goods = int.Parse(Console.ReadLine());

                if (goods <= 3)
                {

                    pricebus = goods * 200;

                    totalpricebus = totalpricebus + pricebus;
                    buscount = buscount + goods;
                }
                if (goods >= 4 && goods <= 11)
                {

                    pricetruck = goods * 175;

                    totalpricetruck = totalpricetruck + pricetruck;
                    truckcount = truckcount + goods;
                }
                if (goods >= 12)
                {

                    pricetrain = goods * 120;

                    totalpricetrain = totalpricetrain + pricetrain;
                    traincount = traincount + goods;
                }

                allgoods = allgoods + goods;

            }
            double total = (totalpricebus + totalpricetruck + totalpricetrain) / allgoods;
            Console.WriteLine("{0:f2}", total);
            Console.WriteLine("{0:f2}%", buscount / allgoods * 100);
            Console.WriteLine("{0:f2}%", truckcount / allgoods * 100);
            Console.WriteLine("{0:f2}%", traincount / allgoods * 100);
        }
    }
}