using System;
using System.Linq;
using System.Numerics;
class FloatingEqulity
{
    public static void Main()
    {
        var eps = 0.000001;
        var numberOne = double.Parse(Console.ReadLine());
        var numberTwo = double.Parse(Console.ReadLine());
        var calculation = Math.Abs(numberOne - numberTwo);
        if (eps > calculation)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
