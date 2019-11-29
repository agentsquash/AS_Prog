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
				{97, new string[]{ "+", " ", " ", " ", " ", " ", " ", " ", " ", " " }},
				{98, new string[]{ "+", "+", " ", " ", " ", " ", " ", " ", " ", " " }},
				{99, new string[]{ "+", "+", "-", " ", " ", " ", " ", " ", " ", " " }},
				{100, new string[]{ "+", "+", "-", "-", " ", " ", " ", " ", " ", " " }},
				{101, new string[]{ "+", "+", "-", "-", "*", " ", " ", " ", " ", " " }},
				{102, new string[]{ "+", "+", "-", "-", "*", "*", " ", " ", " ", " " }},
				{103, new string[]{ "+", "+", "-", "-", "*", "*", "*", " ", " ", " " }},
				{104, new string[]{ "+", "+", "-", "-", "*", "*", "*", ".", " ", " " }},
				{105, new string[]{ "+", "+", "-", "-", "*", "*", "*", ".", ".", " " }},
				{106, new string[]{ "+", "+", "-", "-", "*", "*", "*", ".", ".", "." }} };

			string[] lines = new string[10];
			int shift = 0;

			Console.Write("Enter your design: ");
			char[] input = Console.ReadLine().ToCharArray();

			for (int n = 0; n < input.Length; n++)
			{
				int value = Convert.ToInt32(input[n]); // ASCII values
				if (value > 47 && value < 59) // If ASCII == digit
				{
					shift = (value - 48);  // Converts ASCII value to shift digit.
				}

				else if (value > 96 && value < 107) // If lower case letter.
				{
					for (int i = 0; i < shift; i++)
					{
						lines[i] += " ";
					}

					for (int i = 0; i+shift < lines.Length; i++) // Prints up to line shift.
					{
						lines[i+shift] += dict[value][i];
					}
					shift = 0;
				}

				else // ASCII value is invalid.
					Console.WriteLine("Invalid input");
			}

			for (int i = 9; i > 0; i--)
			{
				Console.WriteLine(lines[i]);
			}
		}
	}
}
