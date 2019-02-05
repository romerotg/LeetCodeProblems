using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Introduction_to_Array
{
	public class LargestNumberAtLeastTwiceOfOthers
	{
		public int DominantIndex(int[] nums)
		{
			int result = -1;

			int largest = 0;
			bool twice = false;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > largest)
				{
					if (nums[i] >= 2 * largest)
						twice = true;
					else
						twice = false;

					largest = nums[i];
					result = i;
				}
				else if (twice && largest >= 2 * nums[i])
					twice = true;
				else
					twice = false;
			}

			if (!twice)
				result = -1;

			return result;
		}

		public int DominantIndex2(int[] nums)
		{
			int result = -1;

			int largest = 0;
			int largestBefore = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > largest)
				{
					largestBefore = largest;
					largest = nums[i];
					result = i;
				}
				else if (nums[i] > largestBefore)
					largestBefore = nums[i];
			}

			if (largest < 2* largestBefore)
				result = -1;

			return result;
		}
	}
}
