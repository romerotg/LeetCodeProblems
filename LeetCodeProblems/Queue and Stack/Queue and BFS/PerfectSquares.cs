using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems.Queue_and_Stack.Queue_and_BFS
{
	public class PerfectSquares
	{
		public int NumSquares(int n)
		{
			if (n <= 0)
				return 0;

			List<int> perfectSquares = _GetPossiblePerfectSquares(n);

			Queue<int> queue = new Queue<int>();
			queue.Enqueue(0);
			int level = 0;

			while (queue.Count > 0)
			{
				int size = queue.Count;

				for (int i = 0; i < size; i++)
				{
					int sum = queue.Dequeue();

					if (sum == n)
						return level;

					for (int j = perfectSquares.Count - 1; j >= 0; j--)
					{
						int newSum = sum + perfectSquares[j];
						if (newSum <= n)
							queue.Enqueue(newSum);
					}
				}

				level++;
			}

			return 0;
		}

		private List<int> _GetPossiblePerfectSquares(int n)
		{
			List<int> result = new List<int>();
			int i = 1;
			int power = 0;

			while (power < n)
			{
				power = i * i;
				if (power <= n)
					result.Add(power);
				i++;
			}

			return result;
		}
	}
}
