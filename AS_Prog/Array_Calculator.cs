using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AS_Prog
{
	public class Array_Calculator
	{
		public static void Run()
		{
			// Array declaration
			int[] ArrayInt = { 23, 1024, 14, 600, 22, 46, 2, 23, 512 };
			string[] ArrayStr = { "Bob", "Barry", "Barbara", "bob", "Beth", "Basil", "Bryn" };
			int choice = 7;

			while (choice != 0)
			{
				Console.WriteLine("Welcome to the Array Calculator");
				Console.WriteLine("-------------------------------");
				Console.WriteLine(" ");
				Console.WriteLine("Type 1 for Min value");
				Console.WriteLine("Type 2 for Max value");
				Console.WriteLine("Type 3 for Total for values");
				Console.WriteLine("Type 4 for Sorted values");
				Console.WriteLine("Type 5 for Mean values");
				Console.WriteLine("Type 6 for Median values");
				Console.WriteLine("Type 0 to leave the program");

				do
				{
					Console.Write("\nEnter your choice: ");
					choice = Convert.ToInt32(Console.ReadLine());
				} while (choice < 0 && choice > 6);

				if (choice == 0)
					break;
				if (choice == 1)
				{
					Console.WriteLine("Minimum: " + Min_Int(ArrayInt));
					Console.WriteLine("Minimum: " + Min_Str(ArrayStr)+"\n");
				}
				if (choice == 2)
				{
					Console.WriteLine("Maximum:  " + MaxInt(ArrayInt));
					Console.WriteLine("Maximum:   " + MaxStr(ArrayStr));
				}

				if (choice == 3)
				{
					Console.WriteLine("Sum:  " + Sum(ArrayInt));
				}

				if (choice == 4)
				{
					int[] SortedArray = Sort(ArrayInt);
					Console.WriteLine("Sorted list: "+string.Join(",", SortedArray));
				}

				if (choice == 5)
				{
					Console.WriteLine("Mean: " + Mean(ArrayInt));
				}

				if (choice == 6)
				{
					Console.WriteLine("Median:   " + Median(ArrayInt));
				}
			}
		}
		public static int MaxInt(int[] ArrayInt)
		{
			int max = ArrayInt[0];
			foreach (int num in ArrayInt)
			{
				if (num > max)
					max = num;
			}
			return max;
		}

		public static string MaxStr(string[] ArrayStr)
		{
			string MaxStr = ArrayStr[0];
			foreach (string phrase in ArrayStr)
			{
				if (phrase.CompareTo(MaxStr) == 1)
					MaxStr = phrase;
			}
			return MaxStr;
		}

		public static int Min_Int(int[] Array)
		{
			int min = Array[0];
			foreach (int num in Array)
			{
				if (num < min)
					min = num;
			}
			return min;
		}
		public static string Min_Str(string[] Array)
		{
			string min = Array[0];
			foreach (string phrase in Array)
			{
				if (phrase.CompareTo(min) == -1)
					min = phrase;
			}
			return min;
		}

		public static int Sum(int[] Array)
		{
			int total = 0;
			foreach (int Num in Array)
			{
				total += Num;
			}
			return total;
		}

		public static int Median(int[] Array_Input)
		{
			int Middle = Array_Input.Length / 2;
			return (Array_Input[Middle]);
		}

		public static double Mean(int[] nums)
		{
			int num = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				num = num + nums[i];
			}
			double mean = num / nums.Length;
			return mean;

		}

		public static int[] Sort(int[] ArrayInt)
		{
			int temp;
			bool sorted = false;
			while (sorted == false)
			{
				sorted = true;
				for (int i = 0; i < ArrayInt.Length - 1; i++)
				{
					if (ArrayInt[i] > ArrayInt[i + 1])
					{
						temp = ArrayInt[i];
						ArrayInt[i] = ArrayInt[i + 1];
						ArrayInt[i + 1] = temp;
						sorted = false;
					}
				}
			}
			return ArrayInt;

		}
	}
}
