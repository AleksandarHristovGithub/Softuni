using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Voleyball





{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNormal = Console.ReadLine();
            double P = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            if (leapOrNormal == "normal")
            {
                double volleyAtHolidays = P * (0.6666667);
                double volleyAtCountry = H;
                double volleyAtWeekends = (48 - H) * (0.75);
                double totalgames = volleyAtHolidays + volleyAtCountry + volleyAtWeekends;
                Console.WriteLine(Math.Floor(totalgames));

            }
            else if (leapOrNormal == "leap")
            {
                double volleyAtHolidays = P * (0.6666667);
                double volleyAtCountry = H;
                double volleyAtWeekends = (48 - H) * (0.75);
                double totalgames = volleyAtHolidays + volleyAtCountry + volleyAtWeekends;
                totalgames += totalgames * 0.15;
                Console.WriteLine(Math.Floor(totalgames));
            }
        }
    }
}
