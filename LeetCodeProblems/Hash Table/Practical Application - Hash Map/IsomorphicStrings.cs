using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map
{
	public class IsomorphicStrings
	{
		public bool IsIsomorphic(string s, string t)
		{
			if (s != null && t != null && s.Length == t.Length)
			{
				Dictionary<char, char> hashmap = new Dictionary<char, char>();
				HashSet<char> mappedChars = new HashSet<char>();

				for (int i = 0; i < s.Length; i++)
				{
					if (hashmap.TryGetValue(s[i], out char c))
					{
						if (c != t[i])
							return false;
					}
					else
					{
						hashmap.Add(s[i], t[i]);

						if (mappedChars.Contains(t[i]))
							return false;
						else
							mappedChars.Add(t[i]);
					}
				}

				return true;
			}

			return false;
		}
	}
}
