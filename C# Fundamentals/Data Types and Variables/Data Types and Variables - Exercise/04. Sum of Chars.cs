using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace SumOfChars





{
    public class Startup
    {
        public static void Main()
        {
            int times = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= times; i++)
            {
                string letterToASCII = Console.ReadLine();
                byte[] asciiBytes = Encoding.ASCII.GetBytes(letterToASCII);


                foreach (var a in asciiBytes)
                {
                    total += a;
                }
            }
            Console.WriteLine($"The sum equals: {total}");
        }
    }
}