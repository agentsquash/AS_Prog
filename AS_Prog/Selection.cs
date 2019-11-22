using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	public class Selection
	{
		public static void Question1()
		{
			int[] boundary = { 80,70,60,50,40,0 };
			string[] grade = { "A", "B", "C", "D", "E", "U" };
			int x = 0;
			Console.Write("Enter mark out of 100: ");
			int mark = Convert.ToInt32(Console.ReadLine());

			while (mark > 0)
			{
				if (mark >= boundary[x])
				{
					Console.WriteLine(grade[x]);
					break;
				}

				else if (mark > 0)
				{
					x++;
				}
				
				else
				{
					break;
				}
			}
		}

		public static void Question2()
		{
			double[] discountRange = { 10000, 5000, 2500, 1000, 0 };
			double[] discount = { 0.8, 0.85, 0.9, 0.95, 1 };
			int x = 0;
			Console.Write("Enter order value: ");
			double value = Convert.ToDouble(Console.ReadLine());

			while (value >= 0)
			{
				if (value >= discountRange[x])
				{
					value *= discount[x];
					Console.WriteLine("The discounted price is {0}",value);
					break;
				}

				else if (value > 0)
				{
					x++;
				}

				else
				{
					break;
				}
			}
		}

		public static void Question3()
		{
			int[] boundary = { 80, 70, 60, 50, 40, 0 };
			string[] grade = { "A", "B", "C", "D", "E", "U" };
			int x = 0;
			int mark = Convert.ToInt32(Console.ReadLine());

			while (true)
			{
				if (mark <= 0 | mark > 100)
				{
					Console.WriteLine("error");
					break;
				}

				if (mark >= boundary[x])
				{
					Console.WriteLine(grade[x]);
					break;
				}

				else if (mark > 0)
				{
					x++;
				}

				else
				{
					break;
				}
			}
		}

		public static void Question4()
		{
			double[] discountRange = { 10000, 5000, 2500, 1000, 0 };
			double[] discount = { 0.8, 0.85, 0.9, 0.95, 1.00 };
			int x = 0;
			double value = Convert.ToDouble(Console.ReadLine());

			if (value == 0)
			{
				Console.WriteLine("0");
			}
			else
			{
				while (true)
				{
					if (value < 0 | value > 25000)
					{
						Console.WriteLine("error");
						break;
					}
					if (value >= discountRange[x])
					{
						value *= discount[x];
						Console.WriteLine("The discounted price is {0}", value);
						break;
					}

					else if (value > 0)
					{
						x++;
					}

					else
					{
						break;
					}
				}
			}
		}
	}
}
