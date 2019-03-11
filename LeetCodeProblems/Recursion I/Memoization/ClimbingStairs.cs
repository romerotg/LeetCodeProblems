using System.Collections.Generic;

namespace LeetCodeProblems.Recursion_I.Memoization
{
	public class ClimbingStairs
	{
		private Dictionary<int, int> hashmap = new Dictionary<int, int>();

		public int ClimbStairs(int n)
		{
			return ClimbStairsRecursive(n);
			//return ClimbStairsIterative(n);
		}

		public int ClimbStairsRecursive(int n)
		{
			if (hashmap.ContainsKey(n))
				return hashmap[n];

			if (n < 3)
			{
				hashmap.Add(n, n);
				return n;
			}

			int count = ClimbStairsRecursive(n - 1) + ClimbStairsRecursive(n - 2);
			hashmap.Add(n, count);
			return count;
		}

		public int ClimbStairsIterative(int n)
		{
			if (n < 3)
				return n;

			int prev1 = 1;
			int prev2 = 2;

			for (int i = 3; i <= n; i++)
			{
				int current = prev1 + prev2;
				prev1 = prev2;
				prev2 = current;
			}

			return prev2;
		}
	}
}
