using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtInCm = double.Parse(Console.ReadLine());
            double widhtInCm = double.Parse(Console.ReadLine());
            double heightInCm = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeOfFishTank = lenghtInCm * widhtInCm * heightInCm;
            double totalLitersItCanHold = volumeOfFishTank * 0.001;
            double percentForTank = percent * 0.01;

            double litersNeeded = totalLitersItCanHold * (1 - percentForTank);
            Console.WriteLine($"{litersNeeded:F3}");
        }
    }
}
