using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());
            double foodExpense = numberOfDogs * 2.50 + numberOfOtherAnimals * 4;
            Console.WriteLine($"{foodExpense:F2} lv.");
        }
    }
}
