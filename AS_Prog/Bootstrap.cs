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
			int[] CoinReturn = CoinCalc.CoinCalc_v3(4.29);
			foreach (int coin in CoinReturn)
			{
				Console.WriteLine(coin);
			}
		}
	}
}
