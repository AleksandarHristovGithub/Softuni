using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfTables = double.Parse(Console.ReadLine());
            double lenghtOfTables = double.Parse(Console.ReadLine());
            double widthOfTables = double.Parse(Console.ReadLine());

            double totalSpaceCover = numberOfTables * (lenghtOfTables + 2 * 0.30) * (widthOfTables + 2 * 0.30);
            double totalSpaceCare = numberOfTables * (lenghtOfTables / 2) * (lenghtOfTables / 2);

            double priceInDollars = totalSpaceCover * 7 + totalSpaceCare * 9;
            double priceInBGN = priceInDollars * 1.85;

            Console.WriteLine($"{priceInDollars:F2} USD");
            Console.WriteLine($"{priceInBGN:F2} BGN");
        }
    }
}
