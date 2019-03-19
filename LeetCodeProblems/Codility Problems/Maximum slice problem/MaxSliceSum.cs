using System;

namespace LeetCodeProblems.Codility_Problems.Maximum_slice_problem
{
	public class MaxSliceSum
	{
		public int solution(int[] A)
		{
			if (A.Length == 1)
				return A[0];

			int maxCurrent = 0;
			int result = int.MinValue;

			foreach (int a in A)
			{
				maxCurrent = Math.Max(a, maxCurrent + a);
				result = Math.Max(result, maxCurrent);
			}

			return result;
		}
	}
}
