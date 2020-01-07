using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class Loops_max_min
	{
		public static void Run()
		{
			int num = Input();
			int max = num;
			int min = num;

			do
			{
				num = Input();
				if (num > max)
					max = num;
				if (num < min)
					min = num;
			} while (num != -1);

			Console.WriteLine("Minimum value: {0} - Maximum value {1}", min, max);

		}

		public static int Input()
		{
			Console.Write("Enter a number: ");
			return Convert.ToInt32(Console.ReadLine());
		}
	}
}
