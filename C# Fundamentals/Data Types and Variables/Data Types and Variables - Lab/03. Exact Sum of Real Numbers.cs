using System;
using System.Linq;
using System.Numerics;
class ExctSumOfRealNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal number = 0;
        for (int i = 1; i <= n; i++)
        {

            decimal numbers = decimal.Parse(Console.ReadLine());

            number += numbers;

        }
        Console.WriteLine(number);


    }
}

