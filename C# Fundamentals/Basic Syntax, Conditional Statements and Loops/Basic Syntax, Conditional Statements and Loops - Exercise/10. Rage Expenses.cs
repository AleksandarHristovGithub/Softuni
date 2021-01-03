using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;

namespace RageExpenses




{
    public class Startup
    {
        static void Main(string[] args)
        {
            double lostGameCount = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalHeadSet = 0;
            double totalMouse = 0;
            double totalKeyboard = 0;
            double totalDisplay = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    totalHeadSet++;
                }
                if (i % 3 == 0)
                {
                    totalMouse++;
                }
                if (i % 6 == 0)
                {
                    totalKeyboard++;
                }
                if (i % 12 == 0)
                {
                    totalDisplay++;
                }
            }
            double totalPrice = headsetPrice * totalHeadSet + mousePrice * totalMouse + keyboardPrice * totalKeyboard + totalDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}