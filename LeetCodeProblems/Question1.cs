using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
	public class Question1
	{
		/*
			Given an array of integers, return indices of the two numbers such that they add up to a specific target.

			You may assume that each input would have exactly one solution, and you may not use the same element twice.

			Example:
				Given nums = [2, 7, 11, 15], target = 9,

				Because nums[0] + nums[1] = 2 + 7 = 9,
				return [0, 1].
		 */
		public int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
						return new int[2] { i, j };
				}
			}
			return null;
		}

		public int[] TwoSum2(int[] nums, int target)
		{
			Dictionary<int, List<int>> numsHash = new Dictionary<int, List<int>>();
			for (int i = 0; i < nums.Length; i++)
			{
				if (numsHash.TryGetValue(nums[i], out var list))
					list.Add(i);
				else
					numsHash.Add(nums[i], new List<int> { i });
			}

			for (int i = 0; i < nums.Length; i++)
			{
				int complement = target - nums[i];

				if (numsHash.TryGetValue(complement, out var indexes))
				{
					foreach (int index in indexes)
						if (index != i)
						return new int[] { i, index };
				}
			}

			return null;
		}
	}
}
