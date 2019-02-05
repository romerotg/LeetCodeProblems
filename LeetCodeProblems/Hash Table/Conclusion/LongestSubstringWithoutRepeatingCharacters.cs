using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Conclusion
{
	public class LongestSubstringWithoutRepeatingCharacters
	{
		public int LengthOfLongestSubstring(string s)
		{
			if (s == null || s.Length == 0)
				return 0;

			int maxLength = 0;
			HashSet<char> set = new HashSet<char>();

			int j = 0;

			for (int i = 0; i < s.Length; i++)
			{
				while (j < s.Length)
				{
					if (!set.Add(s[j]))
					{
						maxLength = Math.Max(maxLength, set.Count);
						set.Remove(s[i]);
						break;
					}
					else
						j++;
				}
			}

			maxLength = Math.Max(maxLength, set.Count);
			return maxLength;
		}
	}
}
