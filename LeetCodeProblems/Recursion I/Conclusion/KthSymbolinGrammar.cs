using System;

namespace LeetCodeProblems.Recursion_I.Conclusion
{
	public class KthSymbolinGrammar
	{
		public int KthGrammar(int N, int K)
		{
			if (N == 0)
				return 0;
			if (N == 1)
				return K == 1 ? 0 : 1;

			int NSize = (int)Math.Pow(2, N - 1);
			int mid = NSize / 2;

			if (K <= mid)
				return KthGrammar(N - 1, K);
			else
				return KthGrammar(N - 1, K - mid) == 0 ? 1 : 0;
		}
	}
}
