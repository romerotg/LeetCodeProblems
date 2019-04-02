using System;

namespace LeetCodeProblems.TT
{
	public class Q3
	{
		public int solution(string S)
		{
			if (S.Length == 1)
				return 0;

			int[] dp = new int[S.Length];
			dp[0] = 1;
			int maxSubsequence = 1;

			for (int i = 1; i < S.Length; i++)
			{
				dp[i] = 1;

				for (int j = 0; j < i; j++)
				{
					if (S[i] >= S[j])
						dp[i] = Math.Max(dp[i], dp[j] + 1);
				}

				maxSubsequence = Math.Max(maxSubsequence, dp[i]);
			}

			return S.Length - maxSubsequence;
		}
	}
}
