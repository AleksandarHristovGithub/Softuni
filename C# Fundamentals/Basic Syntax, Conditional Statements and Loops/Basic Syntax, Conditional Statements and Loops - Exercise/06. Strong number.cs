using System;
using System.Collections.Generic;
using System.Linq;

namespace StrongNumber



{
	class Program
	{

		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			long fact;
			int num = number;
			long sum = 0;

			while (number != 0)
			{
				fact = 1;

				for (int i = 1; i <= number % 10; ++i)
					fact *= i;

				sum += fact;

				number /= 10;
			}

			if (num == sum)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}

	}
}
