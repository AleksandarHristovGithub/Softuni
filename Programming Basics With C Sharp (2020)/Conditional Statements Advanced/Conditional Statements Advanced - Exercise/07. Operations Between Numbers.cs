using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Operations_Between_Numbers





{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operatorForCalc = Console.ReadLine();

            double plus = N1 + N2;
            double minus = N1 - N2;
            double multiply = N1 * N2;
            double divide = N1 / N2;
            if (operatorForCalc == "+")
            {
                if (plus % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {N1 + N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {N1 + N2} - odd");
                }
            }
            if (operatorForCalc == "-")
            {
                if (minus % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {N1 - N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {N1 - N2} - odd");
                }
            }
            if (operatorForCalc == "*")
            {
                if (multiply % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {N1 * N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {N1 * N2} - odd");
                }
            }
            if (operatorForCalc == "/")
            {
                if (N1 != 0 && N2 != 0)
                {
                    Console.WriteLine($"{N1} / {N2} = {N1 / N2:F2}");
                }
                else if (N1 == 0)
                {

                    Console.WriteLine($"Cannot divide {N2} by zero");
                }
                else if (N2 == 0)
                {

                    Console.WriteLine($"Cannot divide {N1} by zero");
                }

            }
            if (operatorForCalc == "%")
            {
                if (N1 != 0 && N2 != 0)
                {
                    Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                }
                else if (N1 == 0)
                {

                    Console.WriteLine($"Cannot divide {N2} by zero");
                }
                else if (N2 == 0)
                {

                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
        }
    }
}