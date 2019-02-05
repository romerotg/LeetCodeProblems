using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Design_the_Key
{
	public class GroupAnagramsQ
	{
		public IList<IList<string>> GroupAnagrams(string[] strs)
		{
			if (strs == null)
				return null;

			Dictionary<string, List<string>> hashmap = new Dictionary<string, List<string>>();

			foreach (string str in strs)
			{
				char[] sortedChars = str.ToCharArray();
				Array.Sort(sortedChars);
				string sortedStr = new string(sortedChars);

				if (!hashmap.TryGetValue(sortedStr, out var group))
				{
					group = new List<string>();
					hashmap.Add(sortedStr, group);
				}
				group.Add(str);

			}

			IList<IList<string>> result = new List<IList<string>>();
			foreach (var value in hashmap.Values)
				result.Add(value);

			return result;
		}

		public List<List<string>> GroupAnagrams2(string[] strs)
		{
			if (strs == null)
				return null;

			Dictionary<string, List<string>> hashmap = new Dictionary<string, List<string>>();

			foreach (string str in strs)
			{
				char[] sortedChars = str.ToCharArray();
				Array.Sort(sortedChars);
				string sortedStr = new string(sortedChars);

				if (!hashmap.TryGetValue(sortedStr, out var group))
				{
					group = new List<string>();
					hashmap.Add(sortedStr, group);
				}
				group.Add(str);

			}

			List<List<string>> result = new List<List<string>>();
			foreach (var value in hashmap.Values)
				result.Add(value);

			return result;
		}
	}
}
