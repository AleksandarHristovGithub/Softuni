using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Supplies_For_School
{

    public class Program
    {


        static void Main(string[] args)
        {
            double numberOfPacketsOfPens = double.Parse(Console.ReadLine());
            double numberOfPacketsOfMarkers = double.Parse(Console.ReadLine());
            double literCleaningAgentForBoard = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double pensPrice = numberOfPacketsOfPens * 5.80;
            double markerPrice = numberOfPacketsOfMarkers * 7.20;
            double cleaningAgentPrice = literCleaningAgentForBoard * 1.20;
            double totalForAll = pensPrice + markerPrice + cleaningAgentPrice;
            double priceWithDiscount = totalForAll - ((totalForAll * percentDiscount) / 100);
            Console.WriteLine($"{priceWithDiscount:F3}");

        }
    }
}
