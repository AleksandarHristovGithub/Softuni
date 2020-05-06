using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double numberOfToys = 0;
            double savedMoney = 0;
            double moneyForBirthday = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += (moneyForBirthday - 1);
                    moneyForBirthday += 10;
                }
                else
                {
                    numberOfToys++;
                }

            }
            savedMoney += numberOfToys * toyPrice;
            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - savedMoney:F2}");
            }
        }
    }
}