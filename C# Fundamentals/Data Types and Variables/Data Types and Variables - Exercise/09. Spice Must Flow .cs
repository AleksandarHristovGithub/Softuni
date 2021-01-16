using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace SpiceMustFlow





{
    public class Startup
    {
        public static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int isOver = 0;
            isOver += startingYield;

            int totalDays = 0;
            int total = 0;

            while (isOver >= 100)
            {
                total += isOver - 26;
                isOver -= 10;
                totalDays++;
                if (isOver < 100)
                {
                    total -= 26;
                }

            }
            Console.WriteLine(totalDays);
            Console.WriteLine(total);
        }
    }
}