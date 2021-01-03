using System;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Vacation




{
    public class Startup
    {
        static void Main(string[] args)
        {
            {
                {
                    double peopleNumber = double.Parse(Console.ReadLine());
                    string peopleType = Console.ReadLine();
                    string day = Console.ReadLine();

                    double priceFridayStudents = 8.45;
                    double priceSaturdayStudents = 9.80;
                    double priceSundayStudents = 10.46;

                    double priceFridayBusiness = 10.90;
                    double priceSaturdayBusiness = 15.60;
                    double priceSundayBusiness = 16.00;

                    double priceFridayRegular = 15.00;
                    double priceSaturdayRegular = 20.00;
                    double priceSundayRegular = 22.50;


                    if (peopleType == "Students" && peopleNumber >= 30 && day == "Friday")
                    {
                        double results = peopleNumber * (priceFridayStudents - (priceFridayStudents * 0.15));
                        Console.WriteLine("Total price: " + $"{results:f2}");
                        Console.ReadLine();
                    }
                    else if (peopleType == "Students" && peopleNumber < 30 && day == "Friday")
                    {
                        double results = priceFridayStudents * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }

                    if (peopleType == "Students" && peopleNumber >= 30 && day == "Saturday")
                    {
                        double results = peopleNumber * (priceSaturdayStudents - (priceSaturdayStudents * 0.15));
                        Console.WriteLine("Total price: " + $"{results:f2}");
                        Console.ReadLine();
                    }
                    else if (peopleType == "Students" && peopleNumber < 30 && day == "Saturday")
                    {
                        double results = priceSaturdayStudents * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    if (peopleType == "Students" && peopleNumber >= 30 && day == "Sunday")
                    {
                        double results = peopleNumber * (priceSundayStudents - (priceSundayStudents * 0.15));
                        Console.WriteLine("Total price: " + $"{results:f2}");
                        Console.ReadLine();
                    }
                    else if (peopleType == "Students" && peopleNumber < 30 && day == "Sunday")
                    {
                        double results = priceSundayStudents * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    if (peopleType == "Business" && peopleNumber >= 100 && day == "Friday")
                    {
                        double results = priceFridayBusiness * peopleNumber - (10 * priceFridayBusiness);
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Business" && peopleNumber < 100 && day == "Friday")
                    {
                        double results = priceFridayBusiness * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    if (peopleType == "Business" && peopleNumber >= 100 && day == "Sunday")
                    {
                        double results = priceSundayBusiness * peopleNumber - (10 * priceSundayBusiness);
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Business" && peopleNumber < 100 && day == "Sunday")
                    {
                        double results = priceSundayBusiness * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    if (peopleType == "Business" && peopleNumber >= 100 && day == "Saturday")
                    {
                        double results = priceSaturdayBusiness * peopleNumber - (10 * priceSaturdayBusiness);
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Business" && peopleNumber < 100 && day == "Saturday")
                    {
                        double results = priceSaturdayBusiness * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    if (peopleType == "Regular" && peopleNumber >= 10 && peopleNumber <= 20 && day == "Friday")
                    {
                        double results = peopleNumber * (priceFridayRegular - (priceFridayRegular * 0.05));
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Regular" && peopleNumber < 10 && day == "Friday")
                    {
                        double results = priceFridayRegular * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Regular" && peopleNumber > 20 && day == "Friday")
                    {
                        double results = priceFridayRegular * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    if (peopleType == "Regular" && peopleNumber >= 10 && peopleNumber <= 20 && day == "Saturday")
                    {
                        double results = peopleNumber * (priceSaturdayRegular - (priceSaturdayRegular * 0.05));
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Regular" && peopleNumber < 10 && day == "Saturday")
                    {
                        double results = priceSaturdayRegular * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Regular" && peopleNumber > 20 && day == "Saturday")
                    {
                        double results = priceSaturdayRegular * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    if (peopleType == "Regular" && peopleNumber >= 10 && peopleNumber <= 20 && day == "Sunday")
                    {
                        double results = peopleNumber * (priceSundayRegular - (priceSundayRegular * 0.05));
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Regular" && peopleNumber < 10 && day == "Sunday")
                    {
                        double results = priceSundayRegular * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                    else if (peopleType == "Regular" && peopleNumber > 20 && day == "Sunday")
                    {
                        double results = priceSundayRegular * peopleNumber;
                        Console.WriteLine("Total price: " + $"{results:f2}");
                    }
                }
            }
        }
    }
}
