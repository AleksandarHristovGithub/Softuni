using System;
using System.Collections.Generic;

namespace PrintAndSum



{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            string numbers = "";
            int sum = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                numbers += i + " ";
                sum += i;

            }
            Console.WriteLine(numbers);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}