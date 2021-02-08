using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace RefactoringPrimeChecker





{
    public class Startup
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool trueOrFalse = true;
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        trueOrFalse = false;
                        break;
                    }
                }
                string boolToLower = trueOrFalse.ToString();
                string boolToLowerEx = boolToLower.ToLower();
                Console.WriteLine("{0} -> {1}", i, boolToLowerEx);

            }
        }
    }
}