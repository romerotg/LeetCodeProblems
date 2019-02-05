using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map
{
	public class TwoSumQ
	{
		public int[] TwoSum(int[] nums, int target)
		{
			Dictionary<int, int> hashmap = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				if (!hashmap.ContainsKey(nums[i]))
					hashmap.Add(nums[i], i);
			}

			for (int i = 0; i < nums.Length; i++)
			{
				int currentTarget = target - nums[i];
				if (hashmap.TryGetValue(currentTarget, out int index) && index != i)
					return new int[] { i, index };
			}

			return null;
		}
	}
}
