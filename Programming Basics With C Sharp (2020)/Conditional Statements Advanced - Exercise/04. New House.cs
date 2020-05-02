using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace New_House





{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            double numberOfFlowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double total = 0.0;
            double totalAfterDiscount = 0.0;
            if (typeOfFlowers == "Roses")
            {
                if (numberOfFlowers <= 80)
                {
                    total += numberOfFlowers * 5;
                    if (total > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - total):F2} leva left.");
                    }
                }
                if (numberOfFlowers > 80)
                {
                    total += numberOfFlowers * 5;
                    total -= total * 0.10;
                    totalAfterDiscount += total;
                    if (totalAfterDiscount > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {totalAfterDiscount - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - totalAfterDiscount):F2} leva left.");
                    }
                }



            }
            if (typeOfFlowers == "Dahlias")
            {
                if (numberOfFlowers <= 90)
                {
                    total += numberOfFlowers * 3.80;
                    if (total > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - total):F2} leva left.");
                    }
                }
                if (numberOfFlowers > 90)
                {
                    total += numberOfFlowers * 3.80;
                    total -= total * 0.15;
                    totalAfterDiscount += total;
                    if (totalAfterDiscount > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {totalAfterDiscount - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - totalAfterDiscount):F2} leva left.");
                    }
                }


            }
            if (typeOfFlowers == "Tulips")
            {
                if (numberOfFlowers <= 80)
                {
                    total += numberOfFlowers * 2.80;
                    if (total > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - total):F2} leva left.");
                    }
                }
                if (numberOfFlowers > 80)
                {
                    total += numberOfFlowers * 2.80;
                    total -= total * 0.15;
                    totalAfterDiscount += total;
                    if (totalAfterDiscount > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {totalAfterDiscount - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - totalAfterDiscount):F2} leva left.");
                    }
                }


            }
            if (typeOfFlowers == "Narcissus")
            {
                if (numberOfFlowers >= 120)
                {
                    total += numberOfFlowers * 3;
                    if (total > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - total):F2} leva left.");
                    }
                }
                if (numberOfFlowers < 120)
                {
                    total += numberOfFlowers * 3;
                    total += total * 0.15;
                    totalAfterDiscount += total;
                    if (totalAfterDiscount > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {totalAfterDiscount - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - totalAfterDiscount):F2} leva left.");
                    }
                }


            }
            if (typeOfFlowers == "Gladiolus")
            {
                if (numberOfFlowers >= 80)
                {
                    total += numberOfFlowers * 2.50;
                    if (total > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - total):F2} leva left.");
                    }
                }
                if (numberOfFlowers < 80)
                {
                    total += numberOfFlowers * 2.50;
                    total += total * 0.20;
                    totalAfterDiscount += total;
                    if (totalAfterDiscount > budget)
                    {
                        Console.WriteLine($"Not enough money, you need {totalAfterDiscount - budget:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {Math.Abs(budget - totalAfterDiscount):F2} leva left.");
                    }
                }


            }

        }
    }
}