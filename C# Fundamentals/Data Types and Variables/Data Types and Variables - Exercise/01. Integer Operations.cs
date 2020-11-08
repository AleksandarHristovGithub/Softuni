using System;
namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int ThirdNumber = int.Parse(Console.ReadLine());
            int FourthNumber = int.Parse(Console.ReadLine());

            int addNums = firstNumber + SecondNumber;
            int divideNums = addNums / ThirdNumber;
            int multiplyNumbs = divideNums * FourthNumber;
            Console.WriteLine(multiplyNumbs);
        }
    }
}