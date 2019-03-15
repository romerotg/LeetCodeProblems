using System;

namespace LeetCodeProblems.Codility_Problems.Time_Complexity
{
	public class TapeEquilibrium
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length == 0)
				return 0;
			if (A.Length == 1)
				return A[0];

			int totalSum = 0;
			int[] PSum = new int[A.Length - 1];
			for (int i = 0; i < A.Length; i++)
			{
				totalSum += A[i];

				if (i < A.Length - 1)
				{
					PSum[i] = A[i];
					if (i > 0)
						PSum[i] += PSum[i - 1];
				}
			}

			int min = int.MaxValue;

			foreach (int p in PSum)
			{
				int dif = Math.Abs(p - (totalSum - p));
				min = Math.Min(min, dif);
			}

			return min;
		}
	}
}
