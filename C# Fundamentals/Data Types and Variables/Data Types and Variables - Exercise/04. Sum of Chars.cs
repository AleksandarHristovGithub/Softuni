using System;
using System.Linq;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte charsCount = byte.Parse(Console.ReadLine());
            int sum = 0;
            while (charsCount > 0)
            {
                sum += char.Parse(Console.ReadLine());
                charsCount--;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}