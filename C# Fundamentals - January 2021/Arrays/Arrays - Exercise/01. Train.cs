using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace Train





{
    public class Startup
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> TrainNumbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                int numbersToAdd = int.Parse(Console.ReadLine());
                TrainNumbers.Add(numbersToAdd);

            }
            int sumList = TrainNumbers.Sum();
            string result = string.Join(" ", TrainNumbers);
            Console.WriteLine(result);
            Console.WriteLine(sumList);

        }
    }
}
