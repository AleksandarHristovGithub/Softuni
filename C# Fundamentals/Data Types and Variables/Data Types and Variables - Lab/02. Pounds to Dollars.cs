using System;
using System.Linq;
class PoundsToDollars
{
    public static void Main()
    {
        double pounds = double.Parse(Console.ReadLine());
        var Usd = pounds * 1.31;
        Console.WriteLine($"{Usd:F3}");





    }
}

