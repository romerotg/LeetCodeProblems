using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Stack_and_DFS
{
	public class NumberofIslands
	{
		public int NumIslands(char[,] grid)
		{
			if (grid == null)
				return 0;

			int rows = grid.GetLength(0);
			int columns = grid.GetLength(1);
			HashSet<Tuple<int, int>> visitedCoordinates = new HashSet<Tuple<int, int>>();
			int islandCount = 0;

			for (int row = 0; row < rows; row++)
			{
				for (int column = 0; column < columns; column++)
				{
					Tuple<int, int> coordinates = new Tuple<int, int>(row, column);
					if (_NumIslands(grid, rows, columns, coordinates, visitedCoordinates))
						islandCount++;
				}
			}

			return islandCount;
		}

		private bool _NumIslands(char[,] grid, int rows, int columns, Tuple<int, int> coordinates, HashSet<Tuple<int, int>> visitedCoordinates)
		{
			if (grid[coordinates.Item1, coordinates.Item2] == '1' && !visitedCoordinates.Contains(coordinates))
			{
				visitedCoordinates.Add(coordinates);
				if (coordinates.Item1 > 0)
					_NumIslands(grid, rows, columns, new Tuple<int, int>(coordinates.Item1 - 1, coordinates.Item2), visitedCoordinates);
				if (coordinates.Item1 < rows - 1)
					_NumIslands(grid, rows, columns, new Tuple<int, int>(coordinates.Item1 + 1, coordinates.Item2), visitedCoordinates);
				if (coordinates.Item2 > 0)
					_NumIslands(grid, rows, columns, new Tuple<int, int>(coordinates.Item1, coordinates.Item2 - 1), visitedCoordinates);
				if (coordinates.Item2 < columns - 1)
					_NumIslands(grid, rows, columns, new Tuple<int, int>(coordinates.Item1, coordinates.Item2 + 1), visitedCoordinates);

				return true;
			}

			return false;
		}
	}
}
