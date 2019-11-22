using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class Gravity
	{
		public static void Run()
		{
			List<string> names = new List<string>();
			List<double> radius = new List<double>();
			List<double> mass = new List<double>();
			double pi = Math.PI;

			double planetVolume, planetMass, planetDensity, planetRadius, objectWeight;
			double gravity = Math.Pow(10, -11);
			double weight = Convert.ToDouble(Console.ReadLine());
			int planetNo = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < planetNo; i++)
			{
				string planetInfo = Console.ReadLine();
				string[] splitInfo = planetInfo.Split(", ");

				names.Add(splitInfo[0]);

				planetRadius = Double.Parse(splitInfo[1]);
				radius.Add(planetRadius);
				planetDensity = Double.Parse(splitInfo[2]);

				planetVolume = 4.0 / 3.0 * pi * Math.Pow(planetRadius, 3.0);
				planetMass = planetDensity * planetVolume;
				mass.Add(planetMass);
			}

			for (int i = 0; i < planetNo; i++)
			{
				objectWeight = gravity * ((mass[i]*weight) / Math.Pow(radius[i], 2.0));
				Console.WriteLine("{0}: {1}",names[i],objectWeight);
			}
		}
	}
}
