using System;
class NumberPattern
{
    public static void Main()
    {
        int q1 = int.Parse(Console.ReadLine());
        int q2 = int.Parse(Console.ReadLine());
        int q3 = int.Parse(Console.ReadLine());
        int[] q = new int[] { q1, q2, q3 };
        // Sort array in ascending order. 
        Array.Sort(q);

        // reverse array 
        Array.Reverse(q);

        // print all element of array 
        foreach (var item in q)
        {
            Console.WriteLine(item.ToString());
        }

    }
}