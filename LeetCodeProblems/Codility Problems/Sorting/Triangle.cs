using System;

namespace LeetCodeProblems.Codility_Problems.Sorting
{
	public class Triangle
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length < 3)
				return 0;

			Array.Sort(A);

			for (int i = 2; i < A.Length; i++)
			{
				if ((long)A[i] + A[i - 1] > A[i - 2] &&
					(long)A[i - 1] + A[i - 2] > A[i] &&
					(long)A[i] + A[i - 2] > A[i - 1])
					return 1;
			}

			return 0;
		}
	}
}
