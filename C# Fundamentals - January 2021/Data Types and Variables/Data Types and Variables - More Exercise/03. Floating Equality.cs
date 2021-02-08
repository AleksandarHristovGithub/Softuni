using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace FloatingEquality





{
    public class Startup
    {

        public static void Main()
        {
            var eps = 0.000001;
            var numberOne = double.Parse(Console.ReadLine());
            var numberTwo = double.Parse(Console.ReadLine());
            var calculation = Math.Abs(numberOne - numberTwo);
            if (eps > calculation)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}