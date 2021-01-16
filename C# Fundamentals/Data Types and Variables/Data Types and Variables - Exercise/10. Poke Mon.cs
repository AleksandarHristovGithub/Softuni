using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace PokeMon





{
    public class Startup
    {

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            double fiftyPercent = N * 0.5;
            int totalPoked = 0;
            while (N >= M)
            {
                N -= M;
                totalPoked++;
                if (N == fiftyPercent && Y != 0)
                {
                    N /= Y;
                }

            }
            Console.WriteLine(N);
            Console.WriteLine(totalPoked);
        }
    }
}