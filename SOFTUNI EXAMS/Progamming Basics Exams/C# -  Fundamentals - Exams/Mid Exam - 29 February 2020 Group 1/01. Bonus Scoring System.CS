using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BonusScoringSystem

{
    class Program
    {
        static void Main(string[] args)
        {
            double bestStudent = 0;
            double lecturesAttendet = 0;

            double countOfStudents = double.Parse(Console.ReadLine());
            double countOfLectures = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            List<double> highestAttendence = new List<double>();
            for (int i = 1; i <= countOfStudents; i++)
            {
                double studentAttendence = double.Parse(Console.ReadLine());
                highestAttendence.Add(studentAttendence);
                if (i == countOfStudents)
                {
                    double maxAttendence = highestAttendence.Max();
                    double totalBonus = Math.Ceiling(maxAttendence / countOfLectures * (5 + initialBonus));

                    bestStudent = totalBonus;
                    lecturesAttendet = maxAttendence;

                }


            }
            Console.WriteLine($"Max Bonus: {bestStudent}.");
            Console.WriteLine($"The student has attended {lecturesAttendet} lectures.");
        }
    }
}
