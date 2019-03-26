using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Caterpillar_method
{
	public class AbsDistinct
	{
		public int solution(int[] A)
		{
			HashSet<int> hash = new HashSet<int>();

			int i = 0;
			int j = A.Length - 1;

			while (i <= j)
			{
				hash.Add(A[i] == int.MinValue ? A[i] : Math.Abs(A[i]));
				i++;

				hash.Add(A[j] == int.MinValue ? A[j] : Math.Abs(A[j]));
				j--;
			}

			return hash.Count;
		}
	}
}
