using System;

namespace Back_In_Thirty_Minutes


{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes >= 59)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours -= 24;

            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}

