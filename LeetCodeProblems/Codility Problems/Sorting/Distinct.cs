using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Sorting
{
	public class Distinct
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length == 0)
				return 0;

			HashSet<int> hash = new HashSet<int>();

			foreach (int a in A)
				hash.Add(a);

			return hash.Count;
		}
	}
}
