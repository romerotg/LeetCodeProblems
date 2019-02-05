using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Set
{
	public class ContainsDuplicateQ
	{
		public bool ContainsDuplicate(int[] nums)
		{
			if (nums != null && nums.Length > 1)
			{
				HashSet<int> numsHash = new HashSet<int>();

				foreach (int num in nums)
				{
					if (numsHash.Contains(num))
						return true;
					else
						numsHash.Add(num);
				}
			}
			return false;
		}
	}
}
