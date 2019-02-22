using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Conclusion
{
	public class Matrix01
	{
		public int[,] UpdateMatrix(int[,] matrix)
		{
			if (matrix == null)
				return null;

			int rows = matrix.GetLength(0);
			int columns = matrix.GetLength(1);


			for (int row = 0; row < rows; row++)
			{
				for (int column = 0; column < columns; column++)
				{
					if (matrix[row, column] == 0)
						continue;

					HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
					Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
					queue.Enqueue(new Tuple<int, int>(row, column));
					int level = 0;

					while (queue.Count > 0)
					{
						int size = queue.Count;

						for (int i = 0; i < size; i++)
						{
							Tuple<int, int> coordinates = queue.Dequeue();

							if (!visited.Contains(coordinates))
							{
								if (matrix[coordinates.Item1, coordinates.Item2] == 0)
								{
									matrix[row, column] = level;
									queue.Clear();
									break;
								}

								visited.Add(coordinates);

								if (coordinates.Item1 > 0)
									queue.Enqueue(new Tuple<int, int>(coordinates.Item1 - 1, coordinates.Item2));
								if (coordinates.Item1 < rows - 1)
									queue.Enqueue(new Tuple<int, int>(coordinates.Item1 + 1, coordinates.Item2));
								if (coordinates.Item2 > 0)
									queue.Enqueue(new Tuple<int, int>(coordinates.Item1, coordinates.Item2 - 1));
								if (coordinates.Item2 < columns - 1)
									queue.Enqueue(new Tuple<int, int>(coordinates.Item1, coordinates.Item2 + 1));
							}
						}

						level++;
					}
				}
			}

			return matrix;
		}
	}
}
