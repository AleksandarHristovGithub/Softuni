using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Cat_Walking
{

    public class Program
    {


        static void Main(string[] args)
        {
            double minutesWalkForDay = double.Parse(Console.ReadLine());
            double totalWalksForDay = double.Parse(Console.ReadLine());
            double caloriesTakenByCat = double.Parse(Console.ReadLine());

            double totalMinutes = minutesWalkForDay * totalWalksForDay;
            double caloriesBurned = totalMinutes * 5;
            double halfCalories = caloriesTakenByCat / 2;
            if (caloriesBurned >= halfCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}