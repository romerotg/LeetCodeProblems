using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Caterpillar_method
{
	public class CountDistinctSlices
	{
		public int solution(int M, int[] A)
		{
			if (A.Length == 1)
				return 1;

			int result = 0;
			HashSet<int> hash = new HashSet<int>();

			int q = 0;
			for (int p = 0; p < A.Length; p++)
			{
				while (q < A.Length && hash.Add(A[q]))
				{
					result += hash.Count;
					if (result > 1_000_000_000)
						return 1_000_000_000;
					q++;
				}

				hash.Remove(A[p]);
			}

			return result;
		}
	}
}
