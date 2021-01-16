using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace BeerKegs





{
    public class Startup
    {
        public static void Main()
        {

            double biggestKeg = 0;
            string modelOfTheKeg = "";
            int times = int.Parse(Console.ReadLine());
            for (int i = 1; i <= times; i++)
            {
                string kegName = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double volume = Math.PI * kegRadius * kegRadius * kegHeight;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    modelOfTheKeg = kegName;
                }
            }
            Console.WriteLine(modelOfTheKeg);
        }
    }
}