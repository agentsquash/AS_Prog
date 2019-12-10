using System;

namespace AS_Prog
{
	class Bootstrap
	{
		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			while (true)
			{
				Sandbox.MagicNumber();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.BackgroundColor = ConsoleColor.Black;
			}
		}
	}
}
