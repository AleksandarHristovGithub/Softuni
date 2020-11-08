using System;
using System.Linq;
using System.Numerics;
class CenturiesToMinutes
{
    public static void Main()
    {
        double centuries = double.Parse(Console.ReadLine());
        double years = centuries * 100;
        double days = (int)(years * 365.2422);
        double hours = 24 * days;
        double minutes = 60 * hours;
        Console.WriteLine(centuries + " centuries " + "= " + years + " years " + "= " + days + " days " + "= " + hours + " hours " + "= " + minutes + " minutes");

    }
}

