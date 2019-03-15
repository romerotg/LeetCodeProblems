using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Counting_Elements
{
	public class FrogRiverOne
	{
		public int solution(int X, int[] A)
		{
			if (A == null || A.Length == 0)
				return 0;

			HashSet<int> hash = new HashSet<int>();
			int count = 0;

			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] >= 1 && A[i] <= X && !hash.Contains(A[i]))
				{
					hash.Add(A[i]);
					count++;

					if (count == X)
						return i;
				}
			}

			return -1;
		}
	}
}
