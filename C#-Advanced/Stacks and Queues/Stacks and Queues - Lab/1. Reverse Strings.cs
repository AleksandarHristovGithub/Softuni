using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace ReverseStrings





{
    public class Startup
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}