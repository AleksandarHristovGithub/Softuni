using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;

namespace ReverseString




{
    public class Startup
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string reversedString = new string(username.Reverse().ToArray());
            Console.WriteLine(reversedString);
        }
    }
}