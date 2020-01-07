using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AS_Prog
{
	class VHS
	{
		const int startTime = 0;
		const int endTime = 1;
		const int programName = 2;

		public static void Run()
		{
			List<string> progStart = new List<string>();
			List<string> progEnd = new List<string>();

			string programInput = " ";
			do
			{
				programInput = Console.ReadLine();
				string[] programTimes = programInput.Split(" ");
				progStart.Add(programTimes[startTime]);
				progEnd.Add(programTimes[endTime]);

			} while (programInput != "");


		}
	}
}
