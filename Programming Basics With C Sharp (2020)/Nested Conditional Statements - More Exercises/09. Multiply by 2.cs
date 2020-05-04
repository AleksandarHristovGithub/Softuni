using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Multiply_by_two










{
    class Program
    {
        static void Main(string[] args)
        {



            double num = 0;

            while (true)
            {


                num = double.Parse(Console.ReadLine());


                if (num >= 0)
                {
                    double result = num * 2;
                    Console.WriteLine($"Result: {result:F2}");
                }
                if (num < 0)
                {

                    Console.WriteLine("Negative number!");
                    break;
                }
            }
        }
    }
}
