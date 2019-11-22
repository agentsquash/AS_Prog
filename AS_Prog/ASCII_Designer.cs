using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class ASCII_Designer
	{
		public static void Run()
		{
			var dict = new Dictionary<string, string[]>
			{
				{"a", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+" }},
				{"b", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+" }},
				{"c", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-" }},
				{"d", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-" }},
				{"e", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*" }},
				{"f", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*" , "*"}},
				{"g", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*", "*", "*" }},
				{"h", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*", "*", "*", "." }},
				{"i", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*", "*", "*", ".", "." }},
				{"j", new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*", "*", "*", ".", ".", "." }} };
		

			string ln1, ln2, ln3, ln4, ln5, ln6, ln7, ln8, ln9, ln10;
			int shift = 0;

			Console.WriteLine(j.Length);

			Console.Write("Enter your design: ");
			char[] input = Console.ReadLine().ToCharArray();

			for (int n = 0; n < input.Length; n++)
			{
				int value = Convert.ToInt32(input[n]);
				if (value > 47 || value < 59)
				{
					shift = (value - 48);
				}

				else
					for (int j = 9; j < 18; j++)
					{

					}
			}
			




		}
	}
}
