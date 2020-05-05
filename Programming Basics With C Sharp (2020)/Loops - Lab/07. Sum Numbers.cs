using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Sum_Numbers











{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCommands = 0;
            int sum = 0;
            while (n > totalCommands)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                totalCommands += 1;

            }
            Console.WriteLine(sum);
        }
    }
}
