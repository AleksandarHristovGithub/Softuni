using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Mountain_Run
{

    public class Program
    {


        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double secondsClimbOneMeter = double.Parse(Console.ReadLine());

            double haveToClimb = distanceMeters * secondsClimbOneMeter;
            double everyFiftyMeters = Math.Floor(distanceMeters / 50) * 30;
            double totalTime = haveToClimb + everyFiftyMeters;
            if (totalTime < recordSeconds)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
            }
            else if (totalTime >= recordSeconds)
            {
                Console.WriteLine($"No! He was {totalTime - recordSeconds:F2} seconds slower.");
            }
        }
    }
}