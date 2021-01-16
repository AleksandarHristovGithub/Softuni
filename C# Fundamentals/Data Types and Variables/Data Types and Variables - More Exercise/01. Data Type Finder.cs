using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;
using System.Data;

namespace DataTypeFinder





{
    public class Startup
    {

        public static void Main()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                bool intTryParseIsSucceess = int.TryParse(command, out int intValue);
                bool doubleTryParseIsSuccess = double.TryParse(command, out double doubleValue);
                bool charTryParseIsSuccess = char.TryParse(command, out char charValue);
                bool boolTryParseIsSuccess = bool.TryParse(command, out bool boolValue);

                if (intTryParseIsSucceess)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (doubleTryParseIsSuccess)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (boolTryParseIsSuccess)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else if (charTryParseIsSuccess)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }

                command = Console.ReadLine();
            }
        }
    }
}