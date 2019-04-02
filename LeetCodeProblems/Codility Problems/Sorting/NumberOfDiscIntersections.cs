using System;

namespace LeetCodeProblems.Codility_Problems.Sorting
{
	public class NumberOfDiscIntersections
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length < 2)
				return 0;

			long[] higher = new long[A.Length];
			long[] lower = new long[A.Length];

			for (int i = 0; i < A.Length; i++)
			{
				lower[i] = (long)i - A[i];
				higher[i] = (long)i + A[i];
			}

			Array.Sort(lower);
			Array.Sort(higher);

			int discsOpened = 0;
			int intersections = 0;
			int l = 0;
			int h = 0;

			while (l < lower.Length)
			{
				if (h < higher.Length && higher[h] < lower[l])
				{
					discsOpened--;
					h++;
				}
				else
				{
					intersections += discsOpened;
					discsOpened++;
					l++;
				}

				if (intersections > 10000000)
					return -1;
			}

			return intersections;
		}
	}
}
