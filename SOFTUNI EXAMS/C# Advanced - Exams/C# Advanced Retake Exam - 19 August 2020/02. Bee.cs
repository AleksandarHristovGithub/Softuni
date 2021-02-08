using System;
using System.Collections.Generic;


namespace Bee
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int row = 0;
            int col = 0;
            int food = 0;

            List<int> list = new List<int>();

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'B')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    matrix[row, col] = '.'; // ������ ����� '.'
                    row = row - 1; // ��������� ��
                    if (row >= 0) // ������ �����
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else // ������ �� ��������� � ������ ���������
                    {
                        Console.WriteLine("The bee got lost!");


                        if (food >= 5)
                        {

                            Console.WriteLine($"Great job, the bee managed to pollinate {food} flowers!");

                            break;
                        }
                        else if (food < 5)
                        {

                            Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - food} flowers more");

                            break;
                        }
                    }
                }
                else if (command == "down")
                {
                    matrix[row, col] = '.'; // ������ ����� '.'
                    row = row + 1; // ��������� ��
                    if (row < n) // ������ �����
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else // ������ �� ��������� � ������ ���������
                    {
                        Console.WriteLine("The bee got lost!");

                        if (food >= 5)
                        {

                            Console.WriteLine($"Great job, the bee managed to pollinate {food} flowers!");

                            break;
                        }
                        else if (food < 5)
                        {

                            Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - food} flowers more");

                            break;
                        }
                    }
                }
                else if (command == "left")
                {
                    matrix[row, col] = '.'; // ������ ����� '.'
                    col = col - 1; // ��������� ��
                    if (col >= 0) // ������ �����
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else // ������ �� ��������� � ������ ���������
                    {
                        Console.WriteLine("The bee got lost!");


                        if (food >= 5)
                        {

                            Console.WriteLine($"Great job, the bee managed to pollinate {food} flowers!");

                            break;
                        }
                        else if (food < 5)
                        {

                            Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - food} flowers more");

                            break;
                        }
                    }
                }
                else if (command == "right")
                {
                    matrix[row, col] = '.'; // ������ ����� '.'
                    col = col + 1; // ��������� ��
                    if (col < n) // ������ �����
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else // ������ �� ��������� � ������ ���������
                    {
                        Console.WriteLine("The bee got lost!");


                        if (food >= 5)
                        {

                            Console.WriteLine($"Great job, the bee managed to pollinate {food} flowers!");

                            break;
                        }
                        else if (food < 5)
                        {

                            Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - food} flowers more");

                            break;
                        }

                    }

                }
                else if (command == "End")
                {
                    if (food >= 5)
                    {

                        Console.WriteLine($"Great job, the bee managed to pollinate {food} flowers!");
                        matrix[row, col] = 'B';
                        break;
                    }
                    else if (food < 5)
                    {

                        Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - food} flowers more");
                        matrix[row, col] = 'B';
                        break;
                    }

                }

                if (matrix[row, col] == 'f') //��� �����
                {
                    food += 1;
                    matrix[row, col] = '.'; // ������� ���������� ������ �� '.'
                }

                else if (matrix[row, col] == 'O')
                {
                    matrix[row, col] = '.';

                    if (command == "up")
                    {
                        row -= 1;

                        if (row < 0)
                        {
                            row = matrix.Length - 1;
                        }

                    }
                    else if (command == "down")
                    {
                        row += 1;

                    }
                    else if (command == "left")
                    {
                        col -= 1;

                        if (col < 0)
                        {
                            col = matrix.Length - 1;
                        }
                    }
                    else if (command == "right")
                    {
                        col += 1;

                    }

                    if (matrix[row, col] == 'f')
                    {
                        food++;
                    }
                    matrix[row, col] = 'B';
                }



            }
            PrintMatrix(n, matrix);
        }

        private static void SnakeMoves(int n, char[,] matrix, ref int row, ref int col, ref int food)
        {
        }

        public static void PrintMatrix(int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}