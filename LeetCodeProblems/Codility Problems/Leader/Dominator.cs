using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Leader
{
	public class Dominator
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length == 0)
				return -1;

			if (A.Length == 1)
				return 0;

			Dictionary<int, int> hashmap = new Dictionary<int, int>();

			foreach (int a in A)
			{
				if (hashmap.ContainsKey(a))
					hashmap[a]++;
				else
					hashmap[a] = 1;
			}

			int half = A.Length / 2;

			foreach (var pair in hashmap)
			{
				if (pair.Value > half)
				{
					for (int i = 0; i < A.Length; i++)
					{
						if (A[i] == pair.Key)
							return i;
					}
				}
			}

			return -1;
		}
	}
}
