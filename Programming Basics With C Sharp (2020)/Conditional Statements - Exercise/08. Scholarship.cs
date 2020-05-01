using System;

namespace Scholarship




{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeBGN = double.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());
            double minimumPay = double.Parse(Console.ReadLine());
            double scholarshipS = minimumPay * 35 / 100;
            double scholarshipE = average * 25;
            if (average >= 5.5)
            {
                if (scholarshipE >= scholarshipS || incomeBGN > minimumPay)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(scholarshipE));
                }
                else
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipS));
                }
            }
            else if (incomeBGN < minimumPay && average > 4.5)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipS));
            }

            else Console.WriteLine("You cannot get a scholarship!");
        }
    }
}
