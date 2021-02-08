using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SumMatrixColumns

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
     .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
     .Select(int.Parse)
     .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            int[] colsSum = new int[cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    colsSum[col] += matrix[row, col];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, colsSum));
        }
    }
}