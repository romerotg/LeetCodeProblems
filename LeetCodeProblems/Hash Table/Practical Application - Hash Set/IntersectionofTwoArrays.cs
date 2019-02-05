using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Set
{
	public class IntersectionofTwoArrays
	{
		public int[] Intersection(int[] nums1, int[] nums2)
		{
			int[] result = null;

			if (nums1 != null && nums2 != null)
			{
				HashSet<int> nums1Hash = new HashSet<int>(nums1);
				HashSet<int> intersection = new HashSet<int>();

				foreach (int num2 in nums2)
				{
					if (nums1Hash.Contains(num2))
						intersection.Add(num2);
				}

				result = new int[intersection.Count];
				int i = 0;
				foreach (int num in intersection)
					result[i++] = num;
			}

			return result;
		}
	}
}
