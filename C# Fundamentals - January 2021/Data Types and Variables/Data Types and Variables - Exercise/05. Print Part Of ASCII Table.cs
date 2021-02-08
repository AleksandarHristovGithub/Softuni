using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace PrintPartOfASCIITable





{
    public class Startup
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string finalWord = "";
            for (int i = start; i <= end; i++)
            {
                char c = Convert.ToChar(i);
                finalWord += c + " ";
            }
            Console.WriteLine(finalWord);
        }
    }
}