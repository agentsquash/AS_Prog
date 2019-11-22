using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AS_Prog
{
	class VariableAssignment
	{
		public static void VariableNaming()
		{
			string[] Split;
			int Length, Case;
			Case = Convert.ToInt32(Console.ReadLine());
			string Input = Console.ReadLine();

			Input = Input.ToLower();
			Split = Input.Split(" ");
			Length = Split.Count();

			if (Case == 0)
			{
				CamelCase(Split, Length);
			}

			else if (Case == 1)
			{
				SnakeCase(Split, Length);
			}

			else if (Case == 2)
			{
				SnakeCase_Caps(Split, Length);
			}

			else
			{
				Console.WriteLine("Invalid case type.");
			}
		}

		public static void CamelCase(string[] Split, int Length)
		{
			string tempString;
			string finalString = "";

			for (int i = 0; i < Length; i++)
			{
				tempString = Split[i];
				finalString = finalString + char.ToUpper(tempString[0]) + tempString.Substring(1);
			}

			Console.WriteLine(finalString);
		}

		public static void SnakeCase(string[] Split, int Length)
		{
			string tempString;

			string finalString = Split[0];

			for (int i = 1; i < Length; i++)
			{
				tempString = Split[i];
				finalString = finalString + "_" + tempString;
			}

			Console.WriteLine(finalString);
		}
		public static void SnakeCase_Caps(string[] Split, int Length)
		{
			string tempString;

			string finalString = Split[0];

			for (int i = 1; i < Length; i++)
			{
				tempString = Split[i];
				finalString = finalString + "_" + tempString;
			}

			finalString = finalString.ToUpper();
			Console.WriteLine(finalString);
		}

		// Extension activity

		public static void VariableChanging()
		{
			string[] Split, SplitCase;
			string Input, Case, tempString, finalString;
			int Length, fromCase, toCase;

			Case = Console.ReadLine();
			Input = Console.ReadLine();

			SplitCase = Case.Split(" ");
			fromCase = Int32.Parse(SplitCase[0]);
			toCase = Int32.Parse(SplitCase[1]);

			if (fromCase >= 1)
			{
				Split = Input.Split("_");
				Length = Split.Count();

				finalString = Split[0];
				
				for (int i = 1; i < Length; i++)
				{
					tempString = Split[i];
					finalString = finalString + " " + tempString;
				}

				finalString = finalString.ToLower();
				Split = finalString.Split(" ");

				if (toCase == 0)
				{
					CamelCase(Split, Length);
				}

				else if (toCase == 1)
				{
					SnakeCase(Split, Length);
				}

				else
				{
					SnakeCase_Caps(Split, Length);
				}
			}
			else
			{
				Split = Regex.Split(Input, @"(?<!^)(?=[A-Z])");
				Length = Split.Count();

				finalString = Split[0];

				for (int i = 1; i < Length; i++)
				{
					tempString = Split[i];
					finalString = finalString + " " + tempString;
				}

				finalString = finalString.ToLower();
				Split = finalString.Split(" ");

				if (toCase == 0)
				{
					CamelCase(Split, Length);
				}

				else if (toCase == 1)
				{
					SnakeCase(Split, Length);
				}

				else
				{
					SnakeCase_Caps(Split, Length);
				}
			}


		}
}
}
