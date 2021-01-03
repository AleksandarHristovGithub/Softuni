using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;

namespace PadawanEquipment




{
    public class Startup
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double priceOfLightSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double freeBelts = Math.Floor(countOfStudents / 6);

            double totalStudents = countOfStudents * 0.10;
            double totalStudentsMath = Math.Ceiling(totalStudents);
            double totalCost = (priceOfLightSabers * ((countOfStudents + totalStudentsMath)) + (priceOfRobes * countOfStudents)) + (priceOfBelts * (countOfStudents - freeBelts));
            if (amountOfMoney < totalCost)
            {
                Console.WriteLine($"Ivan Cho will need {totalCost - amountOfMoney:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
        }
    }
}