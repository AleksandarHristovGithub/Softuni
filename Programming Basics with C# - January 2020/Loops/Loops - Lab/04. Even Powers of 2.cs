using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Even_powers_of_Two










{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;

            }
        }
    }
}