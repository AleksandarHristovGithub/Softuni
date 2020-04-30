using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * a * a:F2}");
            Console.WriteLine($"{2 * Math.PI * a:F2}");
        }
    }
}

