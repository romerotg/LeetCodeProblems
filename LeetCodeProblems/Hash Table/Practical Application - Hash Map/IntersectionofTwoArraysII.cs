using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map
{
	public class IntersectionofTwoArraysII
	{
		public int[] Intersect(int[] nums1, int[] nums2)
		{
			if (nums1 == null || nums2 == null)
				return null;

			Dictionary<int, int> hashmap = new Dictionary<int, int>();
			foreach (var num in nums1)
			{
				if (hashmap.ContainsKey(num))
					hashmap[num]++;
				else
					hashmap[num] = 1;
			}

			List<int> result = new List<int>();
			foreach (var num in nums2)
			{
				if (hashmap.ContainsKey(num) && hashmap[num] > 0)
				{
					hashmap[num]--;
					result.Add(num);
				}
			}
			
			return result.ToArray();
		}
	}
}
