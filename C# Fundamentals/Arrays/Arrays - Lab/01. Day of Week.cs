using System;
using System.Text;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday",
"Thursday", "Friday", "Saturday", "Sunday" };
            if (dayOfWeek >= 1 && dayOfWeek <= 7)
            {

                Console.WriteLine(days[dayOfWeek - 1]);
            }


            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
