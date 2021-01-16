using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace ReverseArrayOfStrings





{
    public class Startup
    {

        public static void Main()
        {

            var items = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < items.Length / 2; i++)

            {

                var oldElement = items[i];

                items[i] = items[items.Length - 1 - i];

                items[items.Length - 1 - i] = oldElement;

            }

            Console.WriteLine(string.Join(" ", items));
        }
    }
}