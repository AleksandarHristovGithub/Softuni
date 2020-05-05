using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram

{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 1; i <= n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (numbers < 200)
                {
                    p1++;
                }
                if (numbers >= 200 && numbers <= 399)
                {
                    p2++;
                }
                if (numbers >= 400 && numbers <= 599)
                {
                    p3++;
                }
                if (numbers >= 600 && numbers <= 799)
                {
                    p4++;
                }
                if (numbers >= 800)
                {
                    p5++;
                }
                while (i == n)
                {
                    Console.WriteLine($"{(p1 = (p1 / n) * 100):F2}%");
                    Console.WriteLine($"{(p2 = (p2 / n) * 100):F2}%");
                    Console.WriteLine($"{(p3 = (p3 / n) * 100):F2}%");
                    Console.WriteLine($"{(p4 = (p4 / n) * 100):F2}%");
                    Console.WriteLine($"{(p5 = (p5 / n) * 100):F2}%");
                    break;
                }
            }


        }
    }
}