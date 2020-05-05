using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double calculation = a * 9 / 5 + 32;
            Console.WriteLine($"{calculation:F2}");
        }
    }
}
