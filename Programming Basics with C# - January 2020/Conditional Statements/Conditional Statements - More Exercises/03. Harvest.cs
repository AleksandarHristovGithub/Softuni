using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Harvest




{
    class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            double Z = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double total = X * Y;
            double wine = 0.40 * total / 2.5;
            if (wine >= Z)
            {
                double left = (wine - Z);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(left)} liters left -> {Math.Ceiling(left / workers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Z - wine)} liters wine needed.");
            }
        }
    }
}