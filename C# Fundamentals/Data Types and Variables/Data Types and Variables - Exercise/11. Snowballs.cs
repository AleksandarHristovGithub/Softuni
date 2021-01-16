using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace SnowBalls





{
    public class Startup
    {
        public static void Main()
        {
            double n = int.Parse(Console.ReadLine());
            BigInteger bestSnowball = 0;
            int firstValue = 0;
            int secondValue = 0;
            int thirdValue = 0;
            string parantesesOne = "(";
            string parantesesTwo = ")";
            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger quality = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (quality > bestSnowball)
                {
                    firstValue = snowballSnow;
                    secondValue = snowballTime;
                    thirdValue = snowballQuality;
                    bestSnowball = quality;

                }
            }
            Console.WriteLine($"{firstValue} : {secondValue} = {bestSnowball} " + parantesesOne + (thirdValue) + parantesesTwo);
        }
    }
}