using System;

namespace Area_of_Figures



{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num1 * num1:F3}");
            }
            else if (figure == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num1 * num2:F3}");
            }
            else if (figure == "circle")
            {
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * (num1 * num1):F3}");
            }
            else if (figure == "triangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num1 * num2 / 2:F3}");
            }
        }
    }
}
