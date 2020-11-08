using System;
using System.Linq;
using System.Numerics;
class DataTypeFinder
{
    public static void Main()
    {

        for (int i = 1; i <= 1000; i++)
        {

            string command = Console.ReadLine();

            Int32 intValue;
            float floatValue;
            bool boolValue;
            char charValue;

            // Place checks higher in if-else statement to give higher priority to type.
            if (command == "END")
            {
                return;
            }
            else if (Int32.TryParse(command, out intValue))
            {
                Console.WriteLine(command + " is integer type");
            }
            else if (float.TryParse(command, out floatValue))
            {
                Console.WriteLine(command + " is floating point type");
            }
            else if (bool.TryParse(command, out boolValue))
            {
                Console.WriteLine(command + " is boolean type");
            }
            else if (char.TryParse(command, out charValue))
            {
                Console.WriteLine(command + " is character type"); ;
            }
            else
            {
                Console.WriteLine(command + " is string type");
            }

        }
    }

}


