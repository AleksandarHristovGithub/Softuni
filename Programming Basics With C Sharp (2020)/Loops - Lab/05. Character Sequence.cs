using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Character_Sequence










{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                Console.WriteLine(letter);
            }

        }
    }
}