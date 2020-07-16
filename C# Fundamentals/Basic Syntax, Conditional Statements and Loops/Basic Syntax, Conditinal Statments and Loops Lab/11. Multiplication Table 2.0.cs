using System;

namespace Multiplication_Table_Two



{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplication = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine(multiplication + " X " + i + " = " + multiplication * i);

            }
            if (times > 10)
            {
                Console.WriteLine(multiplication + " X " + times + " = " + multiplication * times);
            }
        }
    }
}
