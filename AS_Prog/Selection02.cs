using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	public class Selection02
	{
		public static void Question1()
		{
			int value = Convert.ToInt32(Console.ReadLine());
			if (value % 2 == 1) Console.WriteLine("odd");
			else Console.WriteLine("even");
		}

		public static void Question2()
		{
			int age = Convert.ToInt32(Console.ReadLine());
			string testPass = Console.ReadLine();
			if (age > 21)
			{
				if (testPass == "Y") Console.WriteLine("You are allowed to drive the minibus");
				else Console.WriteLine("You are not allowed to drive the minibus");
			}
			else Console.WriteLine("You are not allowed to drive the minibus");
		}

		public static void Question3()
		{
			string name1, name2, name3;

			name1 = Console.ReadLine();
			name2 = Console.ReadLine();
			name3 = Console.ReadLine();

			// name1 less than name2, name3
			if (name1.CompareTo(name2) == -1 & name1.CompareTo(name3) == -1)
			{
				// name1 is first
				if (name2.CompareTo(name3) == -1)
					Console.WriteLine("{0} {1} {2}", name1, name2, name3);
				else
					Console.WriteLine("{0} {1} {2}", name1, name3, name2);
			}
			else if (name2.CompareTo(name1) == -1 & name2.CompareTo(name3) == -1)
			{
				// name 2 is first
				if (name1.CompareTo(name3) == -1)
					Console.WriteLine("{0} {1} {2}", name2, name1, name3);
				else
					Console.WriteLine("{0} {1} {2}", name2, name3, name1);
			}

			// A equal to B less C
			else if (name1.CompareTo(name2) == 0 & name1.CompareTo(name3) == -1)
			{
				Console.WriteLine("{0} {1} {2}", name1, name2, name3);
			}

			// A equal to C less B
			else if (name1.CompareTo(name2) == -1 & name1.CompareTo(name3) == 0)
			{
				Console.WriteLine("{0} {1} {2}", name1, name3, name2);
			}

			// A equal to C and B
			else if (name1.CompareTo(name2) == 0 & name1.CompareTo(name3) == 0)
			{
				Console.WriteLine("{0} {1} {2}", name1, name2, name3);
			}

			else
			{
				if (name1.CompareTo(name2) == -1)
					Console.WriteLine("{0} {1} {2}", name3, name1, name2);
				else
					Console.WriteLine("{0} {1} {2}", name3, name2, name1);
			}
		}

			public static void Question3_v2()
			{
			List<string> Names = new List<string>();
			for (int i = 0; i < 3; i++)
			{
				string inputName = Console.ReadLine();
				Names.Add(inputName);
			}

			Names.Sort();
			Console.WriteLine("{0} {1} {2}", Names[0], Names[1], Names[2]);

		}
	}
}