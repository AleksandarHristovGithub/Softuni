using System;
using System.Linq;

namespace PrintPartOFAsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            for (int c = startNumber; c <= endNumber; c++)
            {
                Console.Write((char)c + " ");
            }
        }
    }
}