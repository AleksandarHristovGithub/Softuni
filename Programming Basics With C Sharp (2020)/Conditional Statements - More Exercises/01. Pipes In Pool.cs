using System;

namespace Pipes_In_Pool




{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double firstPipe = P1 * H;
            double secondPipe = P2 * H;
            double totalLiters = firstPipe + secondPipe;

            double totalPercent = totalLiters / V * 100;
            double P1Persent = P1 * H / totalLiters * 100;
            double P2Persent = P2 * H / totalLiters * 100;
            if (V >= totalLiters)
            {
                Console.WriteLine($"The pool is {totalPercent:F2}% full. Pipe 1: {P1Persent:F2}%. Pipe 2: {P2Persent:F2}%.");
            }
            else if (totalLiters > V)
            {
                Console.WriteLine($"For {H:F2} hours the pool overflows with {totalLiters - V:F2} liters.");
            }
        }
    }
}