using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Caterpillar_method
{
	public class AbsDistinct
	{
		public int solution(int[] A)
		{
			HashSet<int> hash = new HashSet<int>();
			bool hasMinValue = false;

			int i = 0;
			int j = A.Length - 1;

			while (i <= j)
			{
				if (A[i] == int.MinValue)
					hasMinValue = true;
				else
					hash.Add(Math.Abs(A[i]));
				i++;

				if (A[j] == int.MinValue)
					hasMinValue = true;
				else
					hash.Add(Math.Abs(A[j]));
				j--;
			}

			return hash.Count + (hasMinValue ? 1 : 0);
		}
	}
}
