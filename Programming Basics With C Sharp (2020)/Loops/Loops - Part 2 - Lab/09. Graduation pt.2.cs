using System;

namespace Graduation_pt_two
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int count = 0;
            double yearGrade = 0.0;
            double expelled = 0.0;

            while (count < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.0)
                {
                    yearGrade += grade;
                    count++;
                }
                if (grade < 4.0)
                {
                    expelled++;
                    count++;
                }
                double finalGrade = yearGrade / 12;
                if (finalGrade >= 4.00 && count == 12)
                {
                    Console.WriteLine($"{studentName} graduated. Average grade: {finalGrade:f2} ");
                }
                if (expelled == 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {count - 1} grade");
                    break;

                }
            }






        }
    }
}