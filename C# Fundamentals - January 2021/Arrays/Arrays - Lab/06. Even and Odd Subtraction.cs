using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace EvenAndOddSubstraction





{
    public class Startup
    {

        public static void Main()
        {

            int[] numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            int differene = evenSum - oddSum;
            Console.WriteLine(differene);
        }
    }
}
