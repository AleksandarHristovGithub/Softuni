using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double doorArea = 2 * 1.2;
            double windowsArea = 2 * (1.5 * 1.5);
            double frontWallsArea = 2 * (x * x) - doorArea;
            double sideWalls = 2 * (x * y) - windowsArea;
            double totalWallArea = frontWallsArea + sideWalls;
            double greenPaint = totalWallArea / 3.4;
            double roofSquareArea = 2 * (x * y);
            double roofTriangleArea = (x * h);
            double totalRoofArea = roofSquareArea + roofTriangleArea;
            double redPaint = totalRoofArea / 4.3;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
