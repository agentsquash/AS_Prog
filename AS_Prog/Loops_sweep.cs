using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class Loops_sweep
	{
		const int Sections = 5;
		const int Aisles = 6;

		public static void Run()
		{
			Random Rand = new Random();
			int SearchAisle = Rand.Next(0, Aisles);
			int Items = 0;
			int Inflatables = 0;

			char[,] Supermarket ={{'I','X','I','I','S','X'},
			{'X','X','X','S','X','I'},
			{'X','X','S','X','X','I'},
			{'S','X','S','X','S','S'},
			{'X','S','S','X','X','S'}};

			for (int Row = 0; Row < Sections; Row++)
			{
				switch (Supermarket[Row,SearchAisle])
				{
					case 'S':
						Items++;
						break;
					case 'I':
						Inflatables++;
						break;
				}
				Supermarket[SearchAisle, Row] = 'X';
			}

			Console.WriteLine("Searching Aisle {0}\n", SearchAisle);
			Console.WriteLine("Found {0} shopping list items", Items);
			Console.WriteLine("Found {0} inflatable", Inflatables);
		}
	}
}
