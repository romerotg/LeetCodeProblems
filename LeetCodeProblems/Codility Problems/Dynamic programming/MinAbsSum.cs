using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Dynamic_programming
{
	public class MinAbsSum
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length == 0)
				return 0;
			if (A.Length == 1)
				return Math.Abs(A[0]);

			int max = 0;
			for (int i = 0; i < A.Length; i++)
				max += Math.Abs(A[i]);

			Queue<int> queue = new Queue<int>();
			queue.Enqueue(A[0]);
			int minAbs = int.MaxValue;

			for (int i = 1; i < A.Length; i++)
			{
				minAbs = int.MaxValue;

				int size = queue.Count;
				for (int j = 0; j < size; j++)
				{
					int val = queue.Dequeue();

					int sumPositiveOne = Math.Abs(val + A[i]);
					int sumNegativeOne = Math.Abs(val - A[i]);

					int minAbsSum = Math.Min(sumPositiveOne, sumNegativeOne);
					minAbs = Math.Min(minAbs, minAbsSum);

					queue.Enqueue(sumPositiveOne);
					queue.Enqueue(sumNegativeOne);
				}
			}

			return minAbs;
		}
	}
}
