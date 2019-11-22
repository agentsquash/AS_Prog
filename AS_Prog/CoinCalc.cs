using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class CoinCalc
	{
		public static void Coin_Calc()
		{
			double[] coinTypes = { 200, 100, 50, 20, 10, 5, 2, 1 };
			string[] coinStrings = { "£2: ", "£1: ", "50p: ", "20p: ", "10p: ", "5p: ", "2p: ", "1p: " };
			int i = 0; // Current location in coinTypes / coinStrings array
			int coinValue = 0;

			double moneyLeft = Convert.ToDouble(Console.ReadLine());
			moneyLeft *= 100;

			while (true)
			{
				if (moneyLeft >= coinTypes[i])
				{
					coinValue++;

				}
				else if (moneyLeft >= 0)
				{
					if (i < coinStrings.Length)
					{
						i++;
					}
				}
				else
				{
					break;
				}

			}
		}
		public static void CoinCalc_v2()
		{
			double[] coinTypes = { 200, 100, 50, 20, 10, 5, 2, 1 };
			string[] coinStrings = { "£2: ", "£1: ", "50p: ", "20p: ", "10p: ", "5p: ", "2p: ", "1p: " };
			int coinValue = 0;
			double moneyLeft = Convert.ToDouble(Console.ReadLine())*100;

			for (int i = 0; i < coinTypes.Length; i++)
			{
				while (coinTypes[i] <= moneyLeft)
				{
					coinValue++;
					moneyLeft -= coinTypes[i];
				}
				if (coinValue > 0)
					Console.WriteLine(coinStrings[i] + coinValue);
				coinValue = 0;
			}
		}
	}
}
