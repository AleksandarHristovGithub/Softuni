using System;

namespace Multiplication_Table



{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplication = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(multiplication + " X " + i + " = " + multiplication * i);
            }
        }
    }
}
