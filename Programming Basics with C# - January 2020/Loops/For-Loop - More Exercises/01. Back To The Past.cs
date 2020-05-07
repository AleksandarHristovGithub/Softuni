using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int yearsOld = 18;
            for (int i = 1800; i <= year; i++)
            {

                if (i % 2 == 0)
                {
                    inheritance -= 12000;

                }
                else
                {
                    double calc = 12000 + (yearsOld * 50);
                    inheritance -= calc;
                }
                yearsOld += 1;
            }
            if (inheritance >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritance):F2} dollars to survive.");
            }
        }

    }
}