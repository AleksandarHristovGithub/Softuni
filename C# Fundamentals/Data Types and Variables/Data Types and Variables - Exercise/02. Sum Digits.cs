using System;
using System.Linq;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int result = sum.ToString().Sum(c => c - '0');
            Console.WriteLine(result);
        }
    }
}