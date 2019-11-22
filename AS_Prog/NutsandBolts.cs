using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AS_Prog
{
	class NutsandBolts
	{
		public static void Run()
		{
			List<string> Item = new List<string>();
			List<int> Amount = new List<int>();
			List<string> ItemChange = new List<string>();
			List<int> AmountChange = new List<int>();

			int items = Convert.ToInt32(Console.ReadLine());
			
			for (int i = 0; i < items; i++)
			{
				string Input = Console.ReadLine();
				string[] Split = Input.Split(" ");

				Item.Add(Split[0]);
				Amount.Add(Int32.Parse(Split[1]));
			}

			for (int i = 0; i < items; i++)
			{
				string Input = Console.ReadLine();
				string[] Split = Input.Split(" ");

				int loc = Item.IndexOf(Split[0]);
				int original = Amount.ElementAt(loc);
				int change = Int32.Parse(Split[1]);

				if (original > change || original < change)
				{
					ItemChange.Add(Split[0]);
					int final = change - original;
					AmountChange.Add(final);
				}
			}

			for (int i = 0; i < ItemChange.Count; i++)
				Console.WriteLine("{0} {1}",ItemChange[i],AmountChange[i]);
		}
	}
}
