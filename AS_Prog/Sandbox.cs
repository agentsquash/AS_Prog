using System;

namespace AS_Prog
{
	class Sandbox
	{

		public static void numbers()
		{
			int num1 = getNumber(1, 1);
			int num2 = getNumber(1, 2);
			int num3 = getNumber(1, 3);

			Console.WriteLine("{0}, {1}, {2}",num1,num2,num3);
		}
		public static int getNumber(int min, int max)
		{
			int num;
			do
			{
				Console.WriteLine("Enter a number between {0} and {1}",min,max);
				num = Convert.ToInt32(Console.ReadLine());
			} while (num < min || num > max);

			return num;
		}

		public static void whileIntro()
		{
			//int num = Convert.ToInt32(Console.ReadLine());

			//while (num < 1 || num > 10)
			//{
			//	Console.WriteLine("Invalid input");
			//	num = Convert.ToInt32(Console.ReadLine());
			//}

			//Console.WriteLine(num);

			int num;

			do {
				num = Convert.ToInt32(Console.ReadLine());
			} while (num < 1 || num > 10);

			Console.WriteLine(num);
		}

		public static void FizzBuzz()
		{
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i < num; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
					Console.WriteLine("FizzBuzz");
				else if (i % 3 == 0)
					Console.WriteLine("Fizz");
				else if (i % 5 == 0)
					Console.WriteLine("Buzz");
				else
					Console.WriteLine(i);
			}
		}
		public static void Assessment_1()
		{
			Console.WriteLine("Temperature calculator");

			Console.Write("Art temperature: ");
			int ArtTemp = Convert.ToInt32(Console.ReadLine());
			Console.Write("English temperature: ");
			int EngTemp = Convert.ToInt32(Console.ReadLine());
			Console.Write("Music temperature: ");
			int MusTemp = Convert.ToInt32(Console.ReadLine());

			int AvgTemp = (ArtTemp + EngTemp + MusTemp) / 3;
			Console.WriteLine("Average temperature: "+AvgTemp);
			if (AvgTemp < 17)
				Console.WriteLine("Heating should be on");
			else
				Console.WriteLine("Heating should be off");
		}

		public static void Run()
		{
			//int i = 1;
			//string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

			//foreach(string Month in months)
			//{
			//	Console.WriteLine("Month {0}: {1}",i,Month);
			//	i++;
			//}
			//Console.WriteLine("Sandbox");

			//string Bacon = "Smokey";
			//Console.WriteLine(Bacon.Substring(2, 3));


			//string Name = Console.ReadLine();

			//if (Name.CompareTo("Barry") == -1)
			//{
			//	Console.WriteLine("Name less than Barry");
			//}

			//else if (Name.CompareTo("Barry") == 0)
			//{
			//	Console.WriteLine("Name same as Barry");
			//}

			//else if (Name.CompareTo("Barry") == 1)
			//{
			//	Console.WriteLine("Name greater than Barry");
			//}

		}

	}
}
