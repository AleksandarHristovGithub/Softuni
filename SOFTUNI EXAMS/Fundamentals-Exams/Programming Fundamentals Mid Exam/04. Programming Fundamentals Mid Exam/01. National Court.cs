using System;
using System.Collections.Generic;
using System.Linq;

namespace NationalCourth
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmpolyee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());

            int totalHours = 0;

            int totalEmployeeHours = firstEmpolyee + secondEmployee + thirdEmployee;


            while (totalPeople > 0)
            {
                totalHours++;
                totalPeople -= totalEmployeeHours;
                if (totalHours % 4 == 0)
                {
                    totalHours++;
                }
            }
            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}