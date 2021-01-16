using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace SumDigits





{
    public class Startup
    {
        public static void Main()
        {
            int numToSum = int.Parse(Console.ReadLine());
            int sum = 0;
            while (numToSum != 0)
            {
                sum += numToSum % 10;
                numToSum /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}