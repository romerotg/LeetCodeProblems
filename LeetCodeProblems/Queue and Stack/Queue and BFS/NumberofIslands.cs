using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Queue_and_BFS
{
	public class NumberofIslands
	{
		public int NumIslands(char[,] grid)
		{
			if (grid == null)
				return 0;

			int xSize = grid.GetLength(0);
			int ySize = grid.GetLength(1);

			if (xSize == 0 || ySize == 0)
				return 0;

			int islands = 0;
			HashSet<Tuple<int, int>> countedIsland = new HashSet<Tuple<int, int>>();

			for (int x = 0; x < xSize; x++)
			{
				for (int y = 0; y < ySize; y++)
				{
					Tuple<int, int> coordinate = new Tuple<int, int>(x, y);

					if (grid[x, y] == '0' || countedIsland.Contains(coordinate))
						continue;

					countedIsland.Add(coordinate);

					Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
					queue.Enqueue(coordinate);

					while (queue.Count > 0)
					{
						coordinate = queue.Dequeue();
						Tuple<int, int> adjacentCoordinate = null;

						if (coordinate.Item1 > 0)
						{
							adjacentCoordinate = new Tuple<int, int>(coordinate.Item1 - 1, coordinate.Item2);
							if (grid[coordinate.Item1 - 1, coordinate.Item2] == '1' && !countedIsland.Contains(adjacentCoordinate))
							{
								countedIsland.Add(adjacentCoordinate);
								queue.Enqueue(adjacentCoordinate);
							}
						}

						if (coordinate.Item1 < xSize - 1)
						{
							adjacentCoordinate = new Tuple<int, int>(coordinate.Item1 + 1, coordinate.Item2);
							if (grid[coordinate.Item1 + 1, coordinate.Item2] == '1' && !countedIsland.Contains(adjacentCoordinate))
							{
								countedIsland.Add(adjacentCoordinate);
								queue.Enqueue(adjacentCoordinate);
							}
						}

						if (coordinate.Item2 > 0)
						{
							adjacentCoordinate = new Tuple<int, int>(coordinate.Item1, coordinate.Item2 - 1);
							if (grid[coordinate.Item1, coordinate.Item2 - 1] == '1' && !countedIsland.Contains(adjacentCoordinate))
							{
								countedIsland.Add(adjacentCoordinate);
								queue.Enqueue(adjacentCoordinate);
							}
						}

						if (coordinate.Item2 < ySize - 1)
						{
							adjacentCoordinate = new Tuple<int, int>(coordinate.Item1, coordinate.Item2 + 1);
							if (grid[coordinate.Item1, coordinate.Item2 + 1] == '1' && !countedIsland.Contains(adjacentCoordinate))
							{
								countedIsland.Add(adjacentCoordinate);
								queue.Enqueue(adjacentCoordinate);
							}
						}
					}
					islands++;
				}
			}


			return islands;
		}
	}
}
