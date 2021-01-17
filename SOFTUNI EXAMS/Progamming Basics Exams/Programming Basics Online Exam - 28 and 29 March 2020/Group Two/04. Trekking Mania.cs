using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Trekking_Mania
{

    public class Program
    {


        static void Main(string[] args)
        {
            double groupNumbers = double.Parse(Console.ReadLine());
            double totalPeople = 0;
            double first = 0;
            double second = 0;
            double third = 0;
            double fourth = 0;
            double fifth = 0;
            for (int i = 1; i <= groupNumbers; i++)
            {
                double eachGroupNumbers = double.Parse(Console.ReadLine());
                totalPeople += eachGroupNumbers;
                if (eachGroupNumbers <= 5)
                {
                    first += eachGroupNumbers;

                }
                if (eachGroupNumbers >= 6 && eachGroupNumbers <= 12)
                {
                    second += eachGroupNumbers;

                }
                if (eachGroupNumbers >= 13 && eachGroupNumbers <= 25)
                {
                    third += eachGroupNumbers;

                }
                if (eachGroupNumbers >= 26 && eachGroupNumbers <= 40)
                {
                    fourth += eachGroupNumbers;

                }
                if (eachGroupNumbers >= 41)
                {
                    fifth += eachGroupNumbers;


                }
            }
            Console.WriteLine($"{first / totalPeople * 100:F2}%");
            Console.WriteLine($"{second / totalPeople * 100:F2}%");
            Console.WriteLine($"{third / totalPeople * 100:F2}%");
            Console.WriteLine($"{fourth / totalPeople * 100:F2}%");
            Console.WriteLine($"{fifth / totalPeople * 100:F2}%");
        }
    }
}