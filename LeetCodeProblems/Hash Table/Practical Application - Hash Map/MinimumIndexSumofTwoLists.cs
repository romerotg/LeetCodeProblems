using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map
{
	public class MinimumIndexSumofTwoLists
	{
		public string[] FindRestaurant(string[] list1, string[] list2)
		{
			Dictionary<string, int> indexesList1 = new Dictionary<string, int>();
			Dictionary<int, List<string>> restaurantsByIndexSum = new Dictionary<int, List<string>>();
			int leastSum = int.MaxValue;

			for (int i = 0; i < list1.Length; i++)
				indexesList1.Add(list1[i], i);

			for (int i = 0; i < list2.Length; i++)
			{
				if (indexesList1.TryGetValue(list2[i], out int index))
				{
					int indexSum = i + index;
					if (!restaurantsByIndexSum.TryGetValue(indexSum, out List<string> restaurants))
					{
						restaurants = new List<string>();
						restaurantsByIndexSum.Add(indexSum, restaurants);
					}
					restaurants.Add(list2[i]);

					if (indexSum < leastSum)
						leastSum = indexSum;
				}
			}

			return restaurantsByIndexSum[leastSum].ToArray();
		}
	}
}
