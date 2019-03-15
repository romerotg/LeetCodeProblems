using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Arrays
{
	public class OddOccurrencesInArray
	{
		public int solution(int[] A)
		{
			Dictionary<int, int> hashmap = new Dictionary<int, int>();

			foreach (int n in A)
			{
				if (hashmap.ContainsKey(n))
					hashmap[n]++;
				else
					hashmap.Add(n, 1);
			}

			int result = -1;

			foreach (var pair in hashmap)
			{
				if (pair.Value % 2 == 1)
				{
					result = pair.Key;
					break;
				}
			}

			return result;
		}
	}
}
