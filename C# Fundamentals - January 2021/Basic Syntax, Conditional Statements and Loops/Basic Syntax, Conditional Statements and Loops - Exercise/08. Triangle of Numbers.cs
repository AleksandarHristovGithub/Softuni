using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;

namespace TriangleOfNumbers




{
    public class Startup
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }

        }
    }
}