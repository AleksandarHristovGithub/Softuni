using System;
using System.Linq;
using System.Text;

namespace SumofOddNumbers


{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
