using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map
{
	public class FirstUniqueCharacterinaString
	{
		public int FirstUniqChar(string s)
		{
			int result = -1;

			if (s != null && s.Length > 0)
			{
				Dictionary<char, int> charCountHashmap = new Dictionary<char, int>();
				Dictionary<char, int> charIndexHashmap = new Dictionary<char, int>();

				for (int i = 0; i < s.Length; i++)
				{
					if (charCountHashmap.ContainsKey(s[i]))
						charCountHashmap[s[i]]++;
					else
						charCountHashmap.Add(s[i], 1);

					charIndexHashmap[s[i]] = i;
				}

				foreach (var charCount in charCountHashmap)
				{
					if (charCount.Value == 1)
					{
						result = charIndexHashmap[charCount.Key];
						break;
					}
				}
			}

			return result;
		}
	}
}
