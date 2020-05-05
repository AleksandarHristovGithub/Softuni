using System;

namespace World_Swimming_Record




{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double distanceSwimmed = double.Parse(Console.ReadLine());

            double distanceToSwim = distance * distanceSwimmed;
            double meters = Math.Floor(distance / 15) * 12.5;
            double total = distanceToSwim + meters;


            if (recordSeconds > total)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {total:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {total - recordSeconds:F2} seconds slower.");
            }
        }
    }
}