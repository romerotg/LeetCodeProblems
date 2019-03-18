using System;

namespace LeetCodeProblems.Codility_Problems.Sorting
{
	public class NumberOfDiscIntersections
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length < 2)
				return 0;

			long[] upper = new long[A.Length];
			long[] lower = new long[A.Length];

			for (int i = 0; i < A.Length; i++)
			{
				lower[i] = (long)i - A[i];
				upper[i] = (long)i + A[i];
			}

			Array.Sort(lower);
			Array.Sort(upper);

			int intersections = 0;
			int j = 0;

			for (int i = 0; i < A.Length; i++)
			{
				while (j < A.Length && upper[i] >= lower[j])
				{
					intersections += j; // add j intersections
					intersections -= i; // minus i (avoid double count and self intersection)
					if (intersections > 10_000_000)
						return -1;
					j++;
				}
			}
			
			return intersections;
		}
	}
}
