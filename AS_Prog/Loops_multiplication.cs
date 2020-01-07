using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class Loops_multiplication
	{
		public static void Run()
		{
			Console.WriteLine("Multiplication table");
			Console.Write("What number do you want to go up to? ");
			int grid_size = Convert.ToInt32(Console.ReadLine()); // Recieve table from user.

			Console.Write("    ");
			for (int heading = 1; heading < grid_size+1; heading++)
				Console.Write(heading.ToString().PadLeft(4));
			Console.Write(Environment.NewLine);

			for (int row = 1; row < grid_size+1; row++) // Row loop - includes headings.
			{
				Console.Write(row.ToString().PadLeft(4));
				for (int col = 1; col < grid_size+1; col++)
					Console.Write((row*col).ToString().PadLeft(4));
				Console.Write(Environment.NewLine);
			}
		}
	}
}
