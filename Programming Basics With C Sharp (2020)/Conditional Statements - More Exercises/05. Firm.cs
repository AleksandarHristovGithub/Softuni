using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Firm




{
    class Program
    {
        static void Main(string[] args)
        {
            double neededHours = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double firstWorkHours = (days - (days * 0.10)) * 8;
            double urgentWork = workers * (2 * days);
            double total = firstWorkHours + urgentWork;
            if (neededHours <= total)
            {
                Console.WriteLine($"Yes!{Math.Floor(total - neededHours)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(neededHours - total)} hours needed.");
            }
        }
    }
}