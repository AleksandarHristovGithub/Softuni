using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sunglasses
{


    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('*', 2 * n),
                        new string(' ', n));
                }
                else if (row == (n + 1) / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                        new string('/', 2 * n - 2),
                        new string('|', n));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                        new string('/', 2 * n - 2),
                        new string(' ', n));
                }
            }
        }
    }
}