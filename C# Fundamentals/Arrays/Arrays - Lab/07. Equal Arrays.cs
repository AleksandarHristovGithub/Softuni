using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace EqualArrays





{
    public class Startup
    {

        public static void Main()
        {
            int[] array1 = Console.ReadLine()
                      .Split(" ")
                      .Select(int.Parse)
                      .ToArray();

            int[] array2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

            }

            int sum = array1.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }

    }
}