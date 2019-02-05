using System;

namespace LeetCodeProblems.Array_and_String.Two_Pointer_Technique
{
	public class MinimumSizeSubarraySum
	{
		public int MinSubArrayLen(int s, int[] nums)
		{
			int result = int.MaxValue;

			if (nums != null && nums.Length > 0)
			{
				int left = 0;
				int right = 0;
				int sum = 0;
				while (right < nums.Length)
				{
					sum += nums[right++];
					while (sum >= s)
					{
						result = Math.Min(result, right - left);
						sum -= nums[left++];
					}
				}
			}

			return result == int.MaxValue ? 0 : result;
		}
	}
}
