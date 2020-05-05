using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Sleepy_Tom_Cat




{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());

            int breakTime = time * 127;
            int workDays = (365 - time) * 63;

            int total = 30000 - (breakTime + workDays);
            var hours = Math.Abs(total / 60);
            var mins = Math.Abs(total % 60);

            if (30000 > workDays + breakTime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {mins} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {mins} minutes more for play");
            }
        }
    }
}