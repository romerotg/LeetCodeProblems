using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Introduction_to_Array
{
	public class FindPivotIndex
	{
		public int PivotIndex(int[] nums)
		{
			int result = -1;

			if (nums.Length > 0)
			{
				int[] sumsLeft = new int[nums.Length];

				for (int i = 0; i < nums.Length; i++)
				{
					if (i == 0)
						sumsLeft[i] = nums[i];
					else
						sumsLeft[i] = sumsLeft[i - 1] + nums[i];
				}

				int sumRight = 0;
				for (int i = nums.Length - 1; i >= 0; i--)
				{
					if (i < nums.Length - 1)
						sumRight += nums[i + 1];

					if ((i < 1 ? 0 : sumsLeft[i - 1]) == sumRight)
						result = i;
				}
			}

			return result;
		}
	}
}
