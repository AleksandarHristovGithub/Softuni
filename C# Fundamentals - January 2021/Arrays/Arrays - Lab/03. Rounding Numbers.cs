using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace RoundingNumbers





{
    public class Startup
    {

        public static void Main()
        {


            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = (int)Math
                  .Round(nums[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i] + " => " + roundedNums[i]);
                Console.ReadLine();
            }
        }
    }
}
