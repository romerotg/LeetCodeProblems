using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Set
{
	public class SingleNumberQ
	{
		public int SingleNumber(int[] nums)
		{
			if (nums != null && nums.Length > 0)
			{
				HashSet<int> numsHash = new HashSet<int>();

				foreach (int num in nums)
				{
					if (numsHash.Contains(num))
						numsHash.Remove(num);
					else
						numsHash.Add(num);
				}

				return numsHash.First();
			}

			return -1;
		}

		public int SingleNumber2(int[] nums)
		{
			int result = 0;

			if (nums != null && nums.Length > 0)
			{

				foreach (int num in nums)
					result = result ^ num;
			}

			return result;
		}
	}
}
