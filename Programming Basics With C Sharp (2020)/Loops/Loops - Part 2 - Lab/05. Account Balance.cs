using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sum_Numbers


{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 1; i <= n; i++)
            {
                double balance = double.Parse(Console.ReadLine());
                if (balance > 0)
                {
                    total += balance;
                    Console.WriteLine($"Increase: {balance:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}