using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Pets




{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfDays = double.Parse(Console.ReadLine());
            double leftFoodKG = double.Parse(Console.ReadLine());
            double dogDayFoodKG = double.Parse(Console.ReadLine());
            double catDayFoodKG = double.Parse(Console.ReadLine());
            double turtleDayFoodG = double.Parse(Console.ReadLine());

            double dogFood = numberOfDays * dogDayFoodKG;
            double catFood = numberOfDays * catDayFoodKG;
            double turtleFood = (numberOfDays * turtleDayFoodG) * 0.001;

            double totalFood = dogFood + catFood + turtleFood;
            if (leftFoodKG >= totalFood)
            {
                Console.WriteLine(Math.Floor(leftFoodKG - totalFood) + " kilos of food left.");
            }
            else
            {
                Console.WriteLine(Math.Ceiling(totalFood - leftFoodKG) + " more kilos of food are needed.");
            }
        }
    }
}