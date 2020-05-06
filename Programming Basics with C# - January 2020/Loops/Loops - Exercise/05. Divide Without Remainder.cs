using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Without_Remainder

{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
                while (n == i)
                {
                    Console.WriteLine($"{(p1 = (p1 / n) * 100):F2}%");
                    Console.WriteLine($"{(p2 = (p2 / n) * 100):F2}%");
                    Console.WriteLine($"{(p3 = (p3 / n) * 100):F2}%");
                    break;
                }
            }
        }
    }
}
