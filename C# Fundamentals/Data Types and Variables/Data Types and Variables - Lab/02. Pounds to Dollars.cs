using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;

namespace ConvertMeterstoKilometers




{
    public class Startup
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double formulaPoundsToDollars = pounds * 1.31;
            Console.WriteLine($"{formulaPoundsToDollars:F3}");
        }
    }
}