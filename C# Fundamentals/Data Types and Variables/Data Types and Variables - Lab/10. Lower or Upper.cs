using System;
using System.Linq;
using System.Numerics;
class LowerOrUpper
{
    public static void Main()
    {
        char ch = (char)Console.Read();
        if (Char.IsLetter(ch))
        {
            if (Char.IsUpper(ch))
            {
                Console.WriteLine("\nupper-case\n");
            }
            else
            {
                Console.WriteLine("\nlower-case\n");
            }
        }

    }
}