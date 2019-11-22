using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	public class Strings01
	{
		public static void Question1()
		{
			string Name = Console.ReadLine();
			if (Name == null)
				Console.WriteLine("0");
			else
				Console.WriteLine(Name.Length);
		}

		public static void Question2()
		{
			string Name = Console.ReadLine();
			if (Name.Length > 1)
				Console.WriteLine("Hello {0}. Your name has {1} characters and your initial is {2}", Name, Name.Length, Name[0]);
			else
				Console.WriteLine("Hello {0}. Your name has {1} character and your initial is {2}", Name, Name.Length, Name[0]);
		}

		public static void Question3()
		{
			string Number = Console.ReadLine();
			Console.WriteLine("+44 {0}", Number.Substring(1));
		}

		public static void Question4()
		{
			string date = Console.ReadLine();
			string[] dateSplit = date.Split("/");
			Console.WriteLine("You were born on the {0}th day of the {1}th month in {2}",dateSplit[0],dateSplit[1],dateSplit[2]);

			
		}

		public static void Question5()
		{
			string date = Console.ReadLine();
			string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", "Feb" };
			int[] monthLength = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31, 29 };
			try
			{
				string[] dateSplit = date.Split("/");
				int day = Int32.Parse(dateSplit[0]);
				int month = Int32.Parse(dateSplit[1]);
				int year = Int32.Parse(dateSplit[2]);

				//Leap year check
				if (DateTime.IsLeapYear(year) & month == 2)
					month = 13;
				else if (month == 2 & day > 28)
					Console.WriteLine("{0} was not a leap year", year);

				// Is the month valid?
				if (month > 0 & month < 13 | month > 0 & month < 14 & DateTime.IsLeapYear(year))
					// Is the day valid?
					if (day == 0 | day > monthLength[month - 1])
						Console.WriteLine("Invalid date");
						// Date valid, output:
						else if (dateSplit[0].EndsWith("1"))
							Console.WriteLine("You were born on the {0}st day of {1} in {2}", dateSplit[0], months[month - 1], dateSplit[2]);
						else if (dateSplit[0] == "02" | dateSplit[0] == "22")
							Console.WriteLine("You were born on the {0}nd day of {1} in {2}", dateSplit[0], months[month - 1], dateSplit[2]);
						else if (dateSplit[0] == "03" | dateSplit[0] == "23")
							Console.WriteLine("You were born on the {0}rd day of {1} in {2}", dateSplit[0], months[month - 1], dateSplit[2]);
						else
							Console.WriteLine("You were born on the {0}th day of {1} in {2}", dateSplit[0], months[month - 1], dateSplit[2]);
				// Month invalid
				else
					Console.WriteLine("Invalid date");
			}
			catch (System.FormatException)
			{ Console.WriteLine("Invalid date"); }
				
		}
	}
}

