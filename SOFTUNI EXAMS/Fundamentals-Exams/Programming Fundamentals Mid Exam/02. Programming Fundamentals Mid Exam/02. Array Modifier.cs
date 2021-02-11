using System;
using System.Linq;
namespace ArrayModifier
class Program
{
    
    static void Main()
    {
        long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

        long temp = 0;
        string checker = Console.ReadLine();
        bool chck = checker.Contains("end");

        while (chck != true)  //While checker !contains "end"
        {
            chck = checker.Contains("end");
            bool multiply = checker.Contains("multiply");
            bool swap = checker.Contains("swap");
            bool decrease = checker.Contains("decrease");

            if (swap == true)
            {
                string[] positions = checker.Split();
                int pos1 = int.Parse(positions[1]);
                int pos2 = int.Parse(positions[2]);

                temp = input[pos1];
                input[pos1] = input[pos2];
                input[pos2] = temp;
            }
            else if (multiply == true)
            {
                string[] positions = checker.Split();
                int pos1 = int.Parse(positions[1]);
                int pos2 = int.Parse(positions[2]);

                input[pos1] *= input[pos2];
            }
            else if (decrease == true)
            {
                input = Array.ConvertAll(input, x => x - 1);
            }
            else if (chck == true)
            {
                chck = true;
                break;
            }
            checker = Console.ReadLine();
        }
        Console.WriteLine(string.Join(", ", input));
    }
}
