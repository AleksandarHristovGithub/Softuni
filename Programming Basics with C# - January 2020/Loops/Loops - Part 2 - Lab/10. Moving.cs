using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {


            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();


            int roomVolume = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;
            bool isThereEnoughSpace = true;

            while (command != "Done")
            {

                int boxes = int.Parse(command);

                roomVolume -= boxes;

                if (roomVolume < 0)
                {
                    isThereEnoughSpace = false;
                    break;
                }

                command = Console.ReadLine();
            }



            if (isThereEnoughSpace)
            {
                Console.WriteLine($"{roomVolume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(roomVolume)} Cubic meters more.");
            }

        }
    }
}