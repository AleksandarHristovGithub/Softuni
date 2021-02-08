using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace LowerToUpper





{
    public class Startup
    {
        public static void Main()
        {
            string lowerOrUpper = Console.ReadLine();

            if (lowerOrUpper.Any(ch => char.IsUpper(ch)))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}