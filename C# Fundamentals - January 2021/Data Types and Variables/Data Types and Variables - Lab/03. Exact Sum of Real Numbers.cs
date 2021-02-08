using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace ExactSumofRealNumbers





{
    public class Startup
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= counter; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                sum += numbers;
            }

            Console.WriteLine(sum);
        }
    }
}   