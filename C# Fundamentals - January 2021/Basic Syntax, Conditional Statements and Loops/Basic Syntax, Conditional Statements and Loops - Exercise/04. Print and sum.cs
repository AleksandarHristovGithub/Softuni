using System;
using System.Linq;
using System.Text;
using System.Globalization;


namespace Printandsum




{
    public class Startup
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write(i + " ");
                sum += i;

            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}