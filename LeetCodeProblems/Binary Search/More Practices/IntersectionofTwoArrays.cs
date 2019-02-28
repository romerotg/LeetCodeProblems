using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Binary_Search.More_Practices
{
	public class IntersectionofTwoArrays
	{
		public int[] Intersection(int[] nums1, int[] nums2)
		{
			List<int> result = null;

			if (nums1 != null && nums2 != null)
			{
				HashSet<int> visited = new HashSet<int>();
				result = new List<int>();
				Array.Sort(nums2);

				foreach (int num in nums1)
				{
					if (!visited.Contains(num))
					{
						visited.Add(num);

						int left = 0;
						int right = nums2.Length - 1;

						while (left <= right)
						{
							int middle = left + (right - left) / 2;

							if (nums2[middle] == num)
							{
								result.Add(num);
								break;
							}

							if (nums2[middle] > num)
								right = middle - 1;
							else
								left = middle + 1;
						}
					}
				}
			}

			return result?.ToArray();
		}
	}
}
