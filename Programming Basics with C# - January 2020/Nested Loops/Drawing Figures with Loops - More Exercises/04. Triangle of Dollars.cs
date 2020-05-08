using System;
namespace Triange_Of_Dollars
{
    class program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("$");
                for (int d = 0; d < i; d++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
