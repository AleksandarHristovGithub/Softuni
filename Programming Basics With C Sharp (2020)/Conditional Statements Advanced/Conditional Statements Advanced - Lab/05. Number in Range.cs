using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Number_in_Range





{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number <= 100 && number >= -100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            if (number == 0)
            {
                Console.WriteLine("No");
            }
            if (number > 100)
            {
                Console.WriteLine("No");
            }
            if (number < -100)
            {
                Console.WriteLine("No");
            }
        }
    }
}