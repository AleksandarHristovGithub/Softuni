using System;

namespace Vacation



{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;

            if (day == "Friday")
            {
                if (typeOfPeople == "Students" && numberOfPeople < 30)
                {
                    totalPrice += numberOfPeople * 8.45;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Students" && numberOfPeople >= 30)
                {
                    totalPrice += (numberOfPeople * 8.45);
                    totalPrice -= totalPrice * 0.15;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Business" && numberOfPeople < 100)
                {
                    totalPrice += numberOfPeople * 10.90;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Business" && numberOfPeople >= 100)
                {
                    totalPrice += (numberOfPeople * 10.90);
                    totalPrice -= 10.90 * 10;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Regular" && numberOfPeople < 10 || numberOfPeople > 20)
                {
                    totalPrice += numberOfPeople * 15;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    totalPrice += (numberOfPeople * 15);
                    totalPrice -= totalPrice * 0.05;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
            }
            else if (day == "Saturday")
            {
                if (typeOfPeople == "Students" && numberOfPeople < 30)
                {
                    totalPrice += numberOfPeople * 9.80;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Students" && numberOfPeople >= 30)
                {
                    totalPrice += (numberOfPeople * 9.80);
                    totalPrice -= totalPrice * 0.15;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Business" && numberOfPeople < 100)
                {
                    totalPrice += numberOfPeople * 15.60;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Business" && numberOfPeople >= 100)
                {
                    totalPrice += (numberOfPeople * 15.60);
                    totalPrice -= 15.60 * 10;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Regular" && numberOfPeople < 10 || numberOfPeople > 20)
                {
                    totalPrice += numberOfPeople * 20;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    totalPrice += (numberOfPeople * 20);
                    totalPrice -= totalPrice * 0.05;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
            }
            else if (day == "Sunday")
            {
                if (typeOfPeople == "Students" && numberOfPeople < 30)
                {
                    totalPrice += numberOfPeople * 10.46;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Students" && numberOfPeople >= 30)
                {
                    totalPrice += (numberOfPeople * 10.46);
                    totalPrice -= totalPrice * 0.15;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Business" && numberOfPeople < 100)
                {
                    totalPrice += numberOfPeople * 16;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Business" && numberOfPeople >= 100)
                {
                    totalPrice += (numberOfPeople * 16);
                    totalPrice -= 16 * 10;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Regular" && numberOfPeople < 10 || numberOfPeople > 20)
                {
                    totalPrice += numberOfPeople * 22.50;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
                else if (typeOfPeople == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    totalPrice += (numberOfPeople * 22.50);
                    totalPrice -= totalPrice * 0.05;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                }
            }
        }
    }
}