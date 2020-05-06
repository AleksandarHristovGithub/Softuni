using System;
using System.Collections;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Number_sequence











{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCommands = 0;

            List<int> numbersList = new List<int>();
            while (n > totalCommands)
            {
                int numbers = int.Parse(Console.ReadLine());
                numbersList.Add(numbers);
                totalCommands += 1;
                if (totalCommands == n)
                {
                    Console.WriteLine("Max number: " + numbersList.Max());
                    Console.WriteLine("Min number: " + numbersList.Min());
                }
            }

        }
    }
}
