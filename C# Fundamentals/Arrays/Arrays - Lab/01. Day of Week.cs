using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace DaysOfWeek





{
    public class Startup
    {

        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            string[] DayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(DayOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}