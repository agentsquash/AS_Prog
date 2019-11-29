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
			
			for (int i = 0; i < n; i++)
			{
				gridInput = Iterate(gridInput);
			}
		}

		public static char[,] Iterate(char[,] gridInput)
		{
			
			char[,] returnArray = new char[gridInput.GetLength(0), gridInput.GetLength(1)];
			char[] neighbours = new char[8];
			int active = 0;
			for (int x = 0; x < gridInput.GetLength(0); x++)
			{
				for (int y = 0; y < gridInput.GetLength(1); y++)
				{
					neighbours = GetNeigbours(gridInput, x, y);
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
				}
			}
			return returnArray;
		}

		public static char[] GetNeigbours(char[,] gridInput, int x, int y)
		{
			char[] neighbours = new char[8];
			int xLeft = (x - 1);
			if (xLeft < 0)
				xLeft = gridInput.GetLength(0);
			int xRight = (x + 1);
			if (xRight > gridInput.GetLength(0))
				xRight = 0;
			int yUp = (y - 1);
			if (yUp < 0)
				yUp = gridInput.GetLength(1);
			int yDown = (y + 1);
			if (yDown > gridInput.GetLength(0))
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
