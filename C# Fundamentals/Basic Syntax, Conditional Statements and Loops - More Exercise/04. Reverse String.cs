using System;
using System.Linq;
class ReverseString
{
    public static void Main()
    {
        string originalString = Console.ReadLine();
        string reversedString = new string(originalString.Reverse().ToArray());
        Console.WriteLine(reversedString);

    }
}