using System;
namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostGameCount = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double trashedHeadset = 0;
            double trashedMouse = 0;
            double trashedKeyboard = 0;
            double trashedDisplay = 0;

            for (double i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadset++;
                }
                if (i % 3 == 0)
                {
                    trashedMouse++;
                }
                if (i % 6 == 0)
                {
                    trashedKeyboard++;
                }
                if (i % 12 == 0)
                {
                    trashedDisplay++;
                }
            }
            double totalMoney = headsetPrice * trashedHeadset + mousePrice * trashedMouse + keyboardPrice * trashedKeyboard + displayPrice * trashedDisplay;
            Console.WriteLine($"Rage expenses: {totalMoney:F2} lv.");
        }
    }
}