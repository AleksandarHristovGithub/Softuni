using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace CondenseNumberToArray





{
    public class Startup
    {

        public static void Main()
        {
            int[] mainMasiv = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedMasiv = new int[mainMasiv.Length - 1];

            if (mainMasiv.Length == 1)
            {
                Console.WriteLine(mainMasiv[0]);
                return;
            }

            for (int i = 0; i < mainMasiv.Length; i++)
            {
                for (int j = 0; j < condensedMasiv.Length - i; j++)
                {
                    condensedMasiv[j] = mainMasiv[j] + mainMasiv[j + 1];
                }
                mainMasiv = condensedMasiv;
            }
            Console.WriteLine(condensedMasiv[0]);
        }
    }
}