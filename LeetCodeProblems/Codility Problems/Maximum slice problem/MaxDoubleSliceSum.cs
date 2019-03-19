using System;

namespace LeetCodeProblems.Codility_Problems.Maximum_slice_problem
{
	public class MaxDoubleSliceSum
	{
		public int solution(int[] A)
		{
			if (A.Length == 3)
				return 0;

			int[] maxEndingIndex = new int[A.Length];
			int[] maxStartingIndex = new int[A.Length];

			for (int i = 1; i < A.Length - 1; i++)
				maxEndingIndex[i] = Math.Max(0, maxEndingIndex[i - 1] + A[i]);

			for (int i = A.Length - 2; i > 0; i--)
				maxStartingIndex[i] = Math.Max(0, maxStartingIndex[i + 1] + A[i]);

			int max = 0;
			for (int i = 1; i < A.Length - 1; i++)
			{
				max = Math.Max(max, maxEndingIndex[i - 1] + maxStartingIndex[i + 1]);
			}

			return max;
		}
	}
}
