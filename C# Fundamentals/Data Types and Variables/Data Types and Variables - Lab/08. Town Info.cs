using System;
using System.Linq;
using System.Numerics;
class TiwbUbfi
{
    public static void Main()
    {
        string town = Console.ReadLine();
        ulong population = ulong.Parse(Console.ReadLine());
        int km = int.Parse(Console.ReadLine());

        Console.WriteLine($"Town {town} has population of {population} and area {km} square km.");
    }
}
