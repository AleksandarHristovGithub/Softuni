using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SumMatrixElements

{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = GetMatrixFromConsole();

            if (matrix == null)
            {
                Console.WriteLine($"0{Environment.NewLine}0{Environment.NewLine}0");
            }
            else
            {
                Console.WriteLine(matrix.Length);
                Console.WriteLine(matrix[0].Length);
                Console.WriteLine(matrix.Select(row => row.Sum()).Sum());
            }
        }

        private static int[][] GetMatrixFromConsole()
        {
            var dimmensions = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (dimmensions.Length < 2)
            {
                return null;
            }

            var matrix = new int[dimmensions[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Take(dimmensions[1])
                    .ToArray();
            }

            return matrix;
        }
    }
}