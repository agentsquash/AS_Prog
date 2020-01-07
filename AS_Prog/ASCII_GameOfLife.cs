using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AS_Prog
{
	class ASCII_GameOfLife
	{
		const bool Alive = true;
		const bool Dead = false;

		const int Iterations = 0;
		const int Length = 1;
		const int Width = 2;

		public static void Run_Random()
		{
			int[] values = new int[3];
			values = UserInput();

			// Randomly generate grid.
			bool[,] grid = RandomGrid(values[Width], values[Length]);

			// Iterate through the game.
			for (int i = 0; i < values[Iterations]; i++)
			{
				grid = Iterate(grid);
				PrintGrid(grid, i);
				System.Threading.Thread.Sleep(1000);
			}

		}

		public static void Run()
		{
			int[] values = new int[3];
			values = UserInput();

			// Width = Y, Length = X. Create Grid.
			bool[,] grid = InputGame(values[Width],values[Length]);

			// Iterate through the game.
			for (int i = 0; i < values[Iterations]; i++)
			{
				grid = Iterate(grid);
				PrintGrid(grid, i);
				System.Threading.Thread.Sleep(1000);
			}
		}

		public static int[] UserInput()
		{
			int[] values = new int[3];
			string[] dataInput = Console.ReadLine().Split(" ");
			values[Iterations] = Convert.ToInt32(dataInput[0]);
			values[Length] = Convert.ToInt32(dataInput[1]);
			values[Width] = Convert.ToInt32(dataInput[2]);

			return values;
		}
		public static bool[,] InputGame(int gridX, int gridY)
		{ 
			bool[,] grid = new bool[gridY, gridX];
			for (int i = 0; i < gridY; i++)
			{
				char[] lineInput = Console.ReadLine().ToCharArray();
				for (int j = 0; j < gridX; j++)
				{
					grid[i, j] = lineInput[j] == '#';
				}
			}
			Console.WriteLine("");
			return grid;
		}

		public static bool[,] RandomGrid(int gridX, int gridY)
		{
			Random Rand = new Random();
			bool[,] grid = new bool[gridY, gridX];
			for (int i = 0; i < gridY; i++)
			{
				for (int j = 0; j < gridX; j++)
				{
					int random = Rand.Next(0, 2);
					if (random == 1)
						grid[i, j] = true;
					else
						grid[i, j] = false;
				}	
			}
			Console.WriteLine("");
			return grid;
		}

		public static void PrintGrid(bool[,] gridInput, int iteration)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("==================================== Iteration {0} ====================================",iteration+1);
			for (int i = 0; i < gridInput.GetLength(0); i++)
			{
				for (int j = 0; j < gridInput.GetLength(1); j++)
				{
					if (gridInput[i, j])
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write("#");
					}
					
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(".");
					}
						
				}
				Console.Write(Environment.NewLine);
			}
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Green;
		}
		public static int LiveNeighbours(bool[,] gridInput, int y, int x)
		{ 
			int neighbours = 0;
			int coordX, coordY;
			for (int i = -1; i < 2; i++)
			{
				if (y + i == gridInput.GetLength(0))
					coordY = 0;
				else if (y + i == -1)
					coordY = gridInput.GetLength(0) - 1;
				else
					coordY = y + i;
				for (int j = -1; j < 2; j++)
				{
					if (x + j == gridInput.GetLength(1))
						coordX = 0;
					else if (x + j == -1)
						coordX = gridInput.GetLength(1) - 1;
					else
						coordX = x + j;
					// Check if to increment variable.
					if (gridInput[coordY, coordX] && !(coordX == x && coordY == y))
						neighbours++;
				}
			}
			return neighbours;
		}
		public static bool[,] Iterate(bool[,] gridInput)
		{
			bool[,] grid = new bool[gridInput.GetLength(0), gridInput.GetLength(1)];
			for (int i = 0; i < gridInput.GetLength(0); i++) // For Y.
			{
				for (int j = 0; j < gridInput.GetLength(1); j++) // For X.
				{
					int neighbours = LiveNeighbours(gridInput, i, j);
					grid[i, j] = CellState(gridInput[i, j], neighbours);
				}
			}
			return grid;
		}
		public static bool CellState(bool cell, int neighbours)
		{
			if (neighbours == 3 || cell == Alive && neighbours == 2)
				return Alive;
			return Dead;
		}
	}
}
