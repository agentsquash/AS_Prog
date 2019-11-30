using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	class ASCII_GameOfLife
	{
		public static void Run()
		{
			string[] dataInput = Console.ReadLine().Split(" ");
			int n, length, width;
			n = Convert.ToInt32(dataInput[0]);
			length = Convert.ToInt32(dataInput[1]);
			width = Convert.ToInt32(dataInput[2]);
			char[] lineInput;

			char[,] gridInput = new char[length,width]; // Creating a 2D array to store the grid.
			for (int x = 0; x < length; x++)
			{
				lineInput = Console.ReadLine().ToCharArray(); // User inputs a line, converted to char array.
				for (int y = 0; y < width; y++)
				{
					gridInput[x, y] = lineInput[y];
				}
			}

			Console.WriteLine(""); // Buffer between input and final.
			
			for (int i = 0; i < n; i++)
			{
				gridInput = Iterate(gridInput);
			}

			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Console.Write(string.Format("{0}", gridInput[i, j]));
				}
				Console.Write(Environment.NewLine);
			}

		}

		public static char[,] Iterate(char[,] gridInput)
		{
			
			char[,] returnArray = new char[gridInput.GetLength(0), gridInput.GetLength(1)];
			char[] neighbours = new char[9];
			int active = 0;
			for (int x = 0; x < gridInput.GetLength(0); x++)
			{
				for (int y = 0; y < gridInput.GetLength(0); y++)
				{
					neighbours = GetNeighbours(gridInput, x, y);
					foreach (char character in neighbours)
					{
						if (character == '#')
							active++;
					}
					if (active == 3 && gridInput[x, y] == '.')
						returnArray[x, y] = '#';
					else if (active < 2 && gridInput[x, y] == '#')
						returnArray[x, y] = '.';
					else if (active > 3 && gridInput[x, y] == '#')
						returnArray[x, y] = '.';
					else
						returnArray[x, y] = gridInput[x, y];
					active = 0;
				}
			}
			return returnArray;
		}

		public static char[] GetNeighbours(char[,] gridInput, int x, int y)
		{
			//char[] neighbours = new char[9];
			//for (int i = -1; i < 2; i++)
			//{
			//	if ((x - i) < 0)
			//		i = (gridInput.GetLength(0) - 1);
			//	if ((x + 1 > gridInput.GetLength(0)))
			//		i = 0;
			//	for (int j = -1; j < 2; j++)
			//	{
			//		if (
			//	}
			//}

			char[] neighbours = new char[9];
			int xLeft = (x - 1);
			if (xLeft < 0)
				xLeft = gridInput.GetLength(0) - 1;
			int xRight = (x + 1);
			if (xRight > gridInput.GetLength(0) - 1)
				xRight = 0;
			int yUp = (y - 1);
			if (yUp < 0)
				yUp = gridInput.GetLength(1) - 1;
			int yDown = (y + 1);
			if (yDown > gridInput.GetLength(0) - 1)
				yDown = 0;

			neighbours[0] = gridInput[xLeft, yUp];
			neighbours[1] = gridInput[x, yUp];
			neighbours[2] = gridInput[xRight, yUp];
			neighbours[3] = gridInput[xLeft, y];
			neighbours[4] = gridInput[x, y];
			neighbours[5] = gridInput[xRight, y];
			neighbours[6] = gridInput[xLeft, yDown];
			neighbours[7] = gridInput[x, yDown];
			neighbours[8] = gridInput[xRight, yDown];

			return neighbours;
		}
	}
}
