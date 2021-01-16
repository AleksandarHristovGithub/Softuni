using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace IntegerOperations





{
    public class Startup
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int firstOperation = firstNum + secondNum;
            int secondOperation = firstOperation / thirdNum;
            int thirdOperation = secondOperation * fourthNum;

            Console.WriteLine(thirdOperation);
        }
    }
}