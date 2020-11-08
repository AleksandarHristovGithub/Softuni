using System;
using System.Linq;
class CovertMetersToKilometer
{
    public static void Main()
    {
        var meters = int.Parse(Console.ReadLine());
        var kilometers = meters * 0.001;
        Console.WriteLine($"{kilometers:F2}");





    }
}

