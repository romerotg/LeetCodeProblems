using System;

namespace LeetCodeProblems.Array_and_String.Two_Pointer_Technique
{
	public class ArrayPartitionI
	{
		public int ArrayPairSum(int[] nums)
		{
			int result = 0;

			Array.Sort(nums);

			if (nums.Length == 2)
				result = nums[0];
			else
			{
				int i = 0;
				int j = nums.Length - 2;

				while (i < j)
				{
					result += nums[i] + nums[j];
					i += 2;
					j -= 2;
				}

				if (i == j)
					result += nums[i];
			}

			return result;
		}
	}
}
