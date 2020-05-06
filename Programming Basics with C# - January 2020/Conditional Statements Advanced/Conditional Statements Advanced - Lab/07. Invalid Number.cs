using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Invalid_Number





{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number >= 100 && number <= 200 && number != 0)
            {

            }
            if (number == 0)
            {

            }
            if (number > 200)
            {
                Console.WriteLine("invalid");
            }
            if (number < 100 && number != 0)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}