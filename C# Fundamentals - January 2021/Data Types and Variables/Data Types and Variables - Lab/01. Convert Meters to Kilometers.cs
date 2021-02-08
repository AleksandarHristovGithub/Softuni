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
            double meters = double.Parse(Console.ReadLine());
            double formulaMetersToKm = meters * 0.001;
            Console.WriteLine($"{formulaMetersToKm:F2}");
        }
    }
}