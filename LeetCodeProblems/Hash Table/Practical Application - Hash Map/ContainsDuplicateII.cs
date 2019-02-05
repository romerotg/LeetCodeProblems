using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map
{
	public class ContainsDuplicateII
	{
		public bool ContainsNearbyDuplicate(int[] nums, int k)
		{
			if (nums == null || nums.Length == 0)
				return false;

			Dictionary<int, int> numsLastIndexes = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				if (numsLastIndexes.ContainsKey(nums[i]) && (i - numsLastIndexes[nums[i]]) <= k)
					return true;
				else
					numsLastIndexes[nums[i]] = i;
			}

			return false;
		}
	}
}
