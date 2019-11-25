using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class ASCII_Designer
	{
		public static void Run()
		{
			var dict = new Dictionary<int, string[]>
			{
				{97, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", " ", " ", " ", " ", " ", " ", " ", " ", " " }},
				{98, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", " ", " ", " ", " ", " ", " ", " ", " " }},
				{99, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", " ", " ", " ", " ", " ", " ", " " }},
				{100, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-" }},
				{101, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*" }},
				{102, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*" , "*"}},
				{103, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*", "*", "*" }},
				{104, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*", "*", "*", "." }},
				{105, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*", "*", "*", ".", "." }},
				{106, new string[]{ " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "+", "+", "-", "-", "*", "*", "*", ".", ".", "." }} };
		
			int shift = 0;

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
