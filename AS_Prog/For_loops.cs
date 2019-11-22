using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AS_Prog
{
	public class For_loops
	{
		public static void Run()
		{
			//Question1();
			Question2();
			//Question3();
			//Question4();
		}

		public static void Question1()
		{
			string sentence = Console.ReadLine();
			char[] letters = sentence.ToCharArray();
			int e = 0;

			for (int i = 0; i < sentence.Length; i++)
			{
				if (letters[i] == 'e' | letters[i] == 'E')
					e++;
			}

			Console.WriteLine(e);
		}

		public static void Question2()
		{
			string sentence = Console.ReadLine();
			char[] letters = sentence.ToLower().ToCharArray();
			char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
			int e = 0;

			foreach(char letter in letters)
			{
				if (vowels.Contains(letter))
					e++;
			}

			Console.WriteLine(e);
		}

		public static void Question3()
		{
			string sentence = Console.ReadLine();
			string[] split = sentence.Split(" ");

			if (sentence.Length > 1)
				Console.WriteLine(split.Length);
			else
				Console.WriteLine("0");
		}

		public static void Question4()
		{
			int overScore = 0;

			Console.WriteLine("Score for each ball: ");
			for (int i = 0; i < 6; i++)
			{
				int overTemp = Convert.ToInt32(Console.ReadLine());
				overScore += overTemp;
			}

			if (overScore >= 77)
				Console.WriteLine("Error: invalid score");
			else if (overScore < 0)
				Console.WriteLine("Error: negative score");
			else
				Console.WriteLine(overScore);
		}
	}
}