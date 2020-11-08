using System;
using System.Linq;
using System.Numerics;
class RefactorSpecialNumbers
{
    public static void Main()
    {
      
        int input = int.Parse(Console.ReadLine());
        
        bool numberIsSpecialOrNot = false;
     
        for (int loop = 1; loop <= input; loop++)
        {
      
            int checkIfNumberIsEqualOrNot = 0;
         
            int number = 0;
            number = loop;
            while (loop > 0)
            {
                checkIfNumberIsEqualOrNot += loop % 10;
                loop = loop / 10;
            }
            numberIsSpecialOrNot = (checkIfNumberIsEqualOrNot == 5) || (checkIfNumberIsEqualOrNot == 7) || (checkIfNumberIsEqualOrNot == 11);
            Console.WriteLine("{0} -> {1}", number, numberIsSpecialOrNot);

            loop = number;
        }

    }

}