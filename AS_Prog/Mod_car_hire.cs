using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class Mod_car_hire
	{
	public static void Run()
	{
		string make, model;
		int rate;

		Console.WriteLine("Evason Car Hire Company");
		Console.Write("Enter car make: ");
		make = Console.ReadLine();
		Console.Write("Enter car model: ");
		model = Console.ReadLine();
		Console.Write("Enter daily rate: ");
		rate = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("\nDays		Charge (£)");

		for (int i = 1; i < 15; i++)
		{
			Console.WriteLine("{0}		{1}", i, (i * rate));
		}

		double fortrate = 14 * rate;
		double fortdisc = fortrate * 0.9;
		Console.WriteLine("A 10% discount is available for 14 day hires = £{0}, a saving of £{1}", fortdisc, (fortrate-fortdisc));
		if (make == "VW")
			Console.WriteLine("YOU GET A FREE ROAD ATLAS WITH THIS HIRE");
		}
	}
}
