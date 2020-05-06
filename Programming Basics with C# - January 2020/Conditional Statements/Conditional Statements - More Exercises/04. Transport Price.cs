using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Transport_Price




{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            if (n < 20)
            {
                if (dayOrNight == "day")
                {
                    Console.WriteLine($"{0.70 + n * 0.79:F2}");
                }
                else if (dayOrNight == "night")
                {
                    Console.WriteLine($"{0.70 + n * 0.90:F2}");
                }
            }
            else if (n >= 20 && n < 100)
            {
                if (dayOrNight == "day")
                {
                    Console.WriteLine($"{n * 0.09:F2}");
                }
                else if (dayOrNight == "night")
                {
                    Console.WriteLine($"{n * 0.09:F2}");
                }
            }
            else if (n >= 100)
            {
                if (dayOrNight == "day")
                {
                    Console.WriteLine($"{n * 0.06:F2}");
                }
                else if (dayOrNight == "night")
                {
                    Console.WriteLine($"{n * 0.06:F2}");
                }
            }


        }
    }
}