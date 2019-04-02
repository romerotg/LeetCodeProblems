using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Dynamic_programming
{
	public class NumberSolitaire
	{
		public int solution(int[] A)
		{
			if (A.Length == 2)
				return A[0] + A[1];

			Queue<int> maxQueue = new Queue<int>();
			maxQueue.Enqueue(A[0]);
			int maxQueueSize = A.Length > 6 ? 6 : 6 - A.Length - 1;

			int currentMax = int.MinValue;

			for (int i = 1; i < A.Length; i++)
			{
				int previousMax = maxQueue.Dequeue();
				currentMax = A[i] + previousMax;
				int size = maxQueue.Count;
				maxQueue.Enqueue(previousMax);

				for (int j = 0; j < size; j++)
				{
					previousMax = maxQueue.Dequeue();
					currentMax = Math.Max(currentMax, A[i] + previousMax);
					maxQueue.Enqueue(previousMax);
				}

				if (maxQueue.Count == maxQueueSize)
					maxQueue.Dequeue();

				maxQueue.Enqueue(currentMax);
			}

			return currentMax;
		}
	}
}
