using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace CharsToString





{
    public class Startup
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            Console.WriteLine($"{first}{second}{third}");
        }
    }
}