using System;

namespace LeetCodeProblems.Codility_Problems.Caterpillar_method
{
	public class MinAbsSumOfTwo
	{
		public int solution(int[] A)
		{
			Array.Sort(A);

			int i = 0;
			int j = A.Length - 1;
			int min = Math.Abs(A[i] + A[j]);

			while (i <= j)
			{
				int sum = A[i] + A[j];

				min = Math.Min(min, Math.Abs(sum));

				if (sum == 0)
					break;

				if (sum < 0)
					i++;
				else
					j--;
			}

			return min;
		}
	}
}
