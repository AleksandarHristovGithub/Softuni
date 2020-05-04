using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Bike_Race





{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfFirst = double.Parse(Console.ReadLine());
            double numberOfSecond = double.Parse(Console.ReadLine());
            string typeOfField = Console.ReadLine();

            double crossCountyCheck = numberOfFirst + numberOfSecond;
            if (typeOfField == "trail")
            {
                double total = numberOfFirst * 5.5 + numberOfSecond * 7;
                double expense = total - (total * 0.05);
                Console.WriteLine($"{expense:F2}");
            }
            if (typeOfField == "cross-country")
            {
                if (crossCountyCheck < 50)
                {
                    double total = numberOfFirst * 8 + numberOfSecond * 9.50;
                    double expense = total - (total * 0.05);
                    Console.WriteLine($"{expense:F2}");
                }
                else if (crossCountyCheck >= 50)
                {
                    double total = numberOfFirst * 6 + numberOfSecond * 7.125;

                    double expense = total - (total * 0.05);
                    Console.WriteLine($"{expense:F2}");
                }
            }
            if (typeOfField == "downhill")
            {
                double total = numberOfFirst * 12.25 + numberOfSecond * 13.75;
                double expense = total - (total * 0.05);
                Console.WriteLine($"{expense:F2}");
            }
            if (typeOfField == "road")
            {
                double total = numberOfFirst * 20 + numberOfSecond * 21.50;
                double expense = total - (total * 0.05);
                Console.WriteLine($"{expense:F2}");
            }
        }
    }
}
