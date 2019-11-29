using System;

namespace AS_Prog
{
	class Bootstrap
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			ASCII_GameOfLife.Run();
		}
	}
}
