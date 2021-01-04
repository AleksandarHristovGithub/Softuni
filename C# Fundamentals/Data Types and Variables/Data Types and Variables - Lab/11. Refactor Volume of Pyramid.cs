using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace RefactorVolumeofPyramid





{
    public class Startup
    {
        public static void Main()
        {


            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = (lenght * width * height) / 3;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");

        }
    }
}