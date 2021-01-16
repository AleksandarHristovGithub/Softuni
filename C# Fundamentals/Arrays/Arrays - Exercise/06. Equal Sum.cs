using System;
using System.Linq;

namespace EqualSum

{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int[,] result = new int[2, input.Length];
                result[0, 0] = 0;
                result[1, 0] = input.Sum() - input[0];

                if (input.Length == 1)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        result[0, Math.Max(i, 1)] = result[0, Math.Max(i - 1, 0)] + input[(int)Math.Max(i - 1, 0)];
                        result[1, Math.Max(i, 1)] = result[1, Math.Max(i - 1, 0)] - input[Math.Max(i, 1)];

                        if (result[0, i] == result[1, i])
                        {
                            Console.WriteLine(i);
                            return;
                        }
                    }
                    Console.WriteLine("no");
                }
            }
        }
    }
}