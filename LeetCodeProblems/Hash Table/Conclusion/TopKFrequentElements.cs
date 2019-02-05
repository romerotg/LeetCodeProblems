using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems.Hash_Table.Conclusion
{
	public class TopKFrequentElements
	{
		public IList<int> TopKFrequent(int[] nums, int k)
		{
			int[] mostFrequent = new int[k];

			Dictionary<int, int> numCountHash = new Dictionary<int, int>();

			foreach (var num in nums)
			{
				int oldCount = 0;
				if (numCountHash.ContainsKey(num))
					oldCount = numCountHash[num]++;
				else
					numCountHash[num] = 1;
			}

			var orderedCounts = numCountHash.OrderByDescending(n => n.Value);
			int i = 0;

			foreach (var count in orderedCounts)
			{
				mostFrequent[i] = count.Key;

				if (++i >= k)
					break;
			}

			return mostFrequent;
		}
	}
}
