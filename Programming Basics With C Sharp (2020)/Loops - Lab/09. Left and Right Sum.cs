using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsum = 0;
            var evensum = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evensum += num;
                }
                else
                {
                    oddsum += num;
                }

            }

            int diff = Math.Abs(evensum - oddsum);

            if (evensum == oddsum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evensum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("dif = " + diff);
            }
        }
    }
}