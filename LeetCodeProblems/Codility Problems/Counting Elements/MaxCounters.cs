using System;

namespace LeetCodeProblems.Codility_Problems.Counting_Elements
{
	public class MaxCounters
	{
		public int[] solution(int N, int[] A)
		{
			int[] counters = new int[N];
			int lastAppliedMax = 0;
			int max = 0;

			if (A != null && A.Length > 0)
			{
				foreach (int num in A)
				{
					if (num >= 1 && num <= N)
					{
						counters[num - 1] = Math.Max(lastAppliedMax, counters[num - 1]) + 1;
						max = Math.Max(max, counters[num - 1]);
					}
					else if (num == N + 1)
						lastAppliedMax = max;
				}
			}

			for (int i = 0; i < counters.Length; i++)
			{
				if (counters[i] < lastAppliedMax)
					counters[i] = lastAppliedMax;
			}

			return counters;
		}
	}
}
