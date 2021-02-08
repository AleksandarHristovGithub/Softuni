using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;

namespace StrongNumber




{
    public class Startup
    {
        static void Main(string[] args)
        {
            int i, n, n1, s1 = 0, j;
            int fact;






            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;

            for (j = n; j > 0; j = j / 10)
            {

                fact = 1;
                for (i = 1; i <= j % 10; i++)
                {
                    fact = fact * i;
                }
                s1 = s1 + fact;

            }

            if (s1 == n1)
            {
                Console.Write("yes");
            }
            else
            {
                Console.Write("no");
            }
        }
    }
}