using System;

namespace Clock_Part_Two
{
    class Program
    {
        static void Main()
        {

            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {

                    for (int seconds = 0; seconds <= 59; seconds++)
                    {
                        string result = "";
                        result += $"{hour} : { minutes} : {seconds}";
                        Console.WriteLine(result);
                    }

                }

            }
        }
    }
}