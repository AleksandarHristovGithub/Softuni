using System;
namespace Football_League
class Program
{
    static void Main()
    {
        double kapacitetStadion = double.Parse(Console.ReadLine());
        double broiNaVsichkiFenove = double.Parse(Console.ReadLine());
        string sector = "null";
        double secA = 0;
        double secB = 0;
        double secV = 0;
        double secG = 0;
        for (int i = 0; i < broiNaVsichkiFenove; i++)
        {
            sector = Console.ReadLine();
            if (sector == "A")
            {
                secA += 1;
            }
            else if (sector == "B")
            {
                secB += 1;
            }
            else if (sector == "V")
            {
                secV += 1;
            }
            else if (sector == "G")
            {
                secG += 1;
            }
        }
        secA = secA / broiNaVsichkiFenove * 100;
        secB = secB / broiNaVsichkiFenove * 100;
        secV = secV / broiNaVsichkiFenove * 100;
        secG = secG / broiNaVsichkiFenove * 100;
        double fenoveSprqmoStadion = broiNaVsichkiFenove / kapacitetStadion * 100;

        Console.WriteLine("{0:F2}%", secA);
        Console.WriteLine("{0:F2}%", secB);
        Console.WriteLine("{0:F2}%", secV);
        Console.WriteLine("{0:F2}%", secG);
        Console.WriteLine("{0:F2}%", fenoveSprqmoStadion);
    }
}