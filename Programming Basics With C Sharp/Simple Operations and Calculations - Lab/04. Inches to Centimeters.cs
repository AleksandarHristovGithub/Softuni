using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_To_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double inchToCentimeter = inch * 2.54;
            Console.WriteLine(inchToCentimeter);
        }
    }
}
