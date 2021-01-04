using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace CenturiesToMinutes





{
    public class Startup
    {
        static void Main(string[] args)
        {
            int formulaCenturiesToMinutes = int.Parse(Console.ReadLine());
            int centuriesToYears = formulaCenturiesToMinutes * 100;
            double yearsToDays = (int)(centuriesToYears * 365.2422);
            double DaysToHours = yearsToDays * 24;
            double HoursToMinutes = DaysToHours * 60;
            Console.WriteLine($"{formulaCenturiesToMinutes} centuries = {centuriesToYears:F0} years = {yearsToDays:F0} days = {DaysToHours:F0} hours = {HoursToMinutes:F0} minutes");
        }
    }
}