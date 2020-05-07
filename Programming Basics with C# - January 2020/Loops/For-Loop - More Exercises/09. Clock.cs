using System;

namespace Clock
{
    class Program
    {
        static void Main()
        {

            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    string result = "";

                    result += $"{hour} : { minutes}";
                    Console.WriteLine(result);
                }

            }
        }
    }
}