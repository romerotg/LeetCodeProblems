using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Conclusion
{
	public class FloodFillQ
	{
		public int[,] FloodFill(int[,] image, int sr, int sc, int newColor)
		{
			if (image == null)
				return null;

			int rows = image.GetLength(0);
			int columns = image.GetLength(1);
			int color = image[sr, sc];

			if (color == newColor)
				return image;

			Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
			queue.Enqueue(new Tuple<int, int>(sr, sc));

			while (queue.Count > 0)
			{
				Tuple<int, int> coordinates = queue.Dequeue();

				if (image[coordinates.Item1, coordinates.Item2] == color)
				{
					image[coordinates.Item1, coordinates.Item2] = newColor;

					if (coordinates.Item1 > 0)
					{
						if (image[coordinates.Item1 - 1, coordinates.Item2] == color)
							queue.Enqueue(new Tuple<int, int>(coordinates.Item1 - 1, coordinates.Item2));
					}
					if (coordinates.Item1 < rows - 1)
					{
						if (image[coordinates.Item1 + 1, coordinates.Item2] == color)
							queue.Enqueue(new Tuple<int, int>(coordinates.Item1 + 1, coordinates.Item2));
					}
					if (coordinates.Item2 > 0)
					{
						if (image[coordinates.Item1, coordinates.Item2 - 1] == color)
							queue.Enqueue(new Tuple<int, int>(coordinates.Item1, coordinates.Item2 - 1));
					}
					if (coordinates.Item2 < columns - 1)
					{
						if (image[coordinates.Item1, coordinates.Item2 + 1] == color)
							queue.Enqueue(new Tuple<int, int>(coordinates.Item1, coordinates.Item2 + 1));
					}
				}
			}

			return image;
		}
	}
}
