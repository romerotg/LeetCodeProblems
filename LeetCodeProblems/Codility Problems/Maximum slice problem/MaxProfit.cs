using System;

namespace LeetCodeProblems.Codility_Problems.Maximum_slice_problem
{
	public class MaxProfit
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length < 2)
				return 0;

			int min = int.MaxValue;
			int result = 0;

			foreach (int a in A)
			{
				if (a > min)
					result = Math.Max(result, a - min);
				else
					min = Math.Min(min, a);
			}

			return result;
		}
	}
}
