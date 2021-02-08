using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PrintEvenNumbers

{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> evenNumbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Where(i => i % 2 == 0));
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}