using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int greaterThanFive = 0;
            int betweenFourAndFive = 0;
            int betweenThreeAndFour = 0;
            int PoorerThanThree = 0;
            double average = 0;

            for (int i = 0; i < students; i++)
            {
                double gradeInput = double.Parse(Console.ReadLine());
                if (gradeInput >= 5.00) greaterThanFive++;
                if (gradeInput >= 4.00 && gradeInput <= 4.99) betweenFourAndFive++;
                if (gradeInput >= 3.00 && gradeInput <= 3.99) betweenThreeAndFour++;
                if (gradeInput < 3.00) PoorerThanThree++;
                average += gradeInput;
            }

            Console.WriteLine("Top students: {0:f2}%", (greaterThanFive / (double)students) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (betweenFourAndFive / (double)students) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (betweenThreeAndFour / (double)students) * 100);
            Console.WriteLine("Fail: {0:f2}%", (PoorerThanThree / (double)students) * 100);
            Console.WriteLine("Average: {0:f2}", average / students);
        }
    }
}