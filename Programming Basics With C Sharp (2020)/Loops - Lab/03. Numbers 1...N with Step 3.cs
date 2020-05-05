using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Numbers_one_N_with_Step_three










{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}