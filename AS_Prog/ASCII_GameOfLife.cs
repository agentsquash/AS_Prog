using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class ASCII_GameOfLife
	{
		const bool Alive = true;
		const bool Dead = false;

		public static void Run()
		{
			int iterations, length, width;
			// User inputs length + width to give bottom left coordinate (x = across, y = down)

			string[] dataInput = Console.ReadLine().Split(" ");
			iterations = Convert.ToInt32(dataInput[0]);
			length = Convert.ToInt32(dataInput[1]);
			width = Convert.ToInt32(dataInput[2]);

			// Width = Y, Length = X. Create Grid.
			bool[,] grid = InputGame(width, length);

			// Iterate through the game.
			for (int i = 0; i < iterations; i++)
			{
				grid = Iterate(grid);
			}

			// Print the final state of the grid.
			PrintGrid(grid);
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
		public static void PrintGrid(bool[,] gridInput)
		{
			for (int i = 0; i < gridInput.GetLength(0); i++)
			{
				for (int j = 0; j < gridInput.GetLength(1); j++)
				{
					if (gridInput[i, j] == Alive)
						Console.Write("#");
					else
						Console.Write(".");
				}
				Console.Write(Environment.NewLine);
			}
			Console.WriteLine("");
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
