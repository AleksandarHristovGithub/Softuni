using System;
namespace Square_Frame
{
	public class Program
	{
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			for (int r = 1; r <= n; r++)
			{
				for (int c = 1; c <= n; c++)
				{

					if (c == 1 || c == n)
					{
						if (c == 1 && r == 1 || c == 1 && r == n)
						{
							Console.Write("+ ");
						}
						else if (c == 1)
						{
							Console.Write("| ");
						}
						else if (c == n && r == 1 || c == n && r == n)
						{
							Console.Write("+");
						}
						else
						{
							Console.Write("|");
						}
					}
					else
					{
						Console.Write("- ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}