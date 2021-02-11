using System;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] garden = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    garden[row, col] = 0;
                }
            }
            string input = Console.ReadLine();
            while (input != "Bloom Bloom Plow")
            {
                string[] splitInput = input.Split();
                int nRow = int.Parse(splitInput[0]);
                int mCol = int.Parse(splitInput[1]);
                if (nRow >= 0 && nRow <= rows - 1 && mCol >= 0 && mCol <= cols - 1)
                {
                    for (int i = nRow; i <= nRow; i++)
                    {
                        for (int j = 0; j < garden.GetLength(0); j++)
                        {
                            garden[i, j] += 1;
                        }

                    }
                    for (int i = mCol; i <= mCol; i++)
                    {
                        for (int j = 0; j < garden.GetLength(1); j++)
                        {
                            garden[j, i] += 1;
                        }
                    }
                    garden[nRow, mCol] = 1;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}