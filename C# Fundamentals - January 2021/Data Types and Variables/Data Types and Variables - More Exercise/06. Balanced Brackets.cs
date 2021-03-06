using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace BalancedBrackets





{
    public class Startup
    {

        public static void Main()
        {

            byte numberOfLines = byte.Parse(Console.ReadLine());
            bool isLocked = false;
            byte openingBracketsCount = 0;
            byte closingBracketsCount = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string currentString = Console.ReadLine();
                if (currentString.Length == 1)
                {
                    char currentChar = char.Parse(currentString);
                    openingBracketsCount += currentChar == '(' ? (byte)1 : (byte)0;
                    closingBracketsCount += currentChar == ')' ? (byte)1 : (byte)0;
                    if (!(openingBracketsCount == closingBracketsCount ||
                        openingBracketsCount == closingBracketsCount + 1))
                    {
                        isLocked = true;
                    }
                }

            }

            bool isBalances = openingBracketsCount == closingBracketsCount;
            Console.WriteLine(isBalances && !isLocked ? "BALANCED" : "UNBALANCED");
        }
    }
}