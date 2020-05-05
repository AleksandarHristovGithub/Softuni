using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Vowels_Sum










{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int total = 0;
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == 'a')
                {
                    total += 1;
                }
                if (input[i] == 'e')
                {
                    total += 2;
                }
                if (input[i] == 'i')
                {
                    total += 3;
                }
                if (input[i] == 'o')
                {
                    total += 4;
                }
                if (input[i] == 'u')
                {
                    total += 5;
                }
            }
            Console.WriteLine(total);

        }
    }
}