using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Leader
{
	public class EquiLeader
	{
		public int solution(int[] A)
		{
			int leader;
			int leaderCount = _LeaderCount(A, out leader);
			int result = 0;

			if (leaderCount > 0)
			{
				int leaderCountToCurrentIndex = 0;
				for (int i = 0; i < A.Length; i++)
				{
					if (A[i] == leader)
						leaderCountToCurrentIndex++;

					if ((leaderCountToCurrentIndex > (i + 1) / 2) && (leaderCount - leaderCountToCurrentIndex > (A.Length - (i + 1)) / 2))
						result++;
				}
			}

			return result;
		}

		private int _LeaderCount(int[] A, out int leader)
		{
			leader = -1;

			if (A == null || A.Length == 0)
				return 0;

			if (A.Length == 1)
				return 1;

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
					leader = pair.Key;
					return pair.Value;
				}
			}

			return 0;
		}
	}
}
