using System;
using System.Linq;
using System.Text;

namespace Divisibleby3

{
    public class Startup
    {
        public static void Main(string[] args)
        {
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
