using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Binary_Search.More_Practices_II
{
	public class FindKthSmallestPairDistance
	{
		public int SmallestDistancePair(int[] nums, int k)
		{
			if (nums == null || nums.Length == 0)
				return -1;

			List<int> distances = new List<int>();

			for (int i = 0; i < nums.Length; i++)
				for (int j = i + 1; j < nums.Length; j++)
					distances.Add(Math.Abs(nums[i] - nums[j]));

			distances.Sort();
			return distances[k - 1];
		}
	}
}
