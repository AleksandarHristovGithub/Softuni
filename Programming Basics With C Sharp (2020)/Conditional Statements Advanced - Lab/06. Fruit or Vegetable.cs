using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Fruit_or_Vegetable






{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitOrVegetable = Console.ReadLine();
            switch (fruitOrVegetable)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}