using System.Collections.Generic;

namespace LeetCodeProblems.Recursion_I.Memoization
{
	public class FibonacciNumber
	{
		private Dictionary<int, int> hashmap = new Dictionary<int, int>();

		public int Fib(int N)
		{
			return FibRecursive(N);
			//return FibIterative(N);
		}

		public int FibRecursive(int N)
		{
			if (hashmap.ContainsKey(N))
				return hashmap[N];

			if (N < 2)
			{
				hashmap.Add(N, N);
				return N;
			}

			int fib = FibRecursive(N - 1) + FibRecursive(N - 2);
			hashmap.Add(N, fib);
			return fib;
		}

		public int FibIterative(int N)
		{
			if (N < 2)
				return N;

			int prev1 = 0;
			int prev2 = 1;

			for (int i = 2; i <= N; i++)
			{
				int current = prev1 + prev2;
				prev1 = prev2;
				prev2 = current;
			}

			return prev2;
		}
	}
}
