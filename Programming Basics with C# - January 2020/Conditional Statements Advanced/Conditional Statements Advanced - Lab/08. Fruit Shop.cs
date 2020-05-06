using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Fruit_Shop





{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfVegetable = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (typeOfVegetable)
                    {
                        case "banana":
                            Console.WriteLine($"{amount * 2.50:F2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{amount * 1.20:F2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{amount * 0.85:F2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{amount * 1.45:F2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{amount * 2.70:F2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{amount * 5.50:F2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{amount * 3.85:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Sunday":
                case "Saturday":
                    switch (typeOfVegetable)
                    {
                        case "banana":
                            Console.WriteLine($"{amount * 2.70:F2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{amount * 1.25:F2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{amount * 0.90:F2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{amount * 1.60:F2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{amount * 3.00:F2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{amount * 5.60:F2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{amount * 4.20:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}