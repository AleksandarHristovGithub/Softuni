using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardMetresToGreen = double.Parse(Console.ReadLine());

            double priceToGreenWholeYard = yardMetresToGreen * 7.61;
            double discountPrice = 0.18 * priceToGreenWholeYard;
            double finalPrice = priceToGreenWholeYard - discountPrice;
            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discountPrice:F2} lv.");
        }
    }
}
