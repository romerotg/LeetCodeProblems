using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Conclusion
{
	public class JewelsandStones
	{
		public int NumJewelsInStones(string J, string S)
		{
			if (J == null || S == null)
				return 0;

			int result = 0;

			HashSet<char> jewels = new HashSet<char>();
			foreach (char c in J)
				jewels.Add(c);

			foreach (char c in S)
				if (jewels.Contains(c))
					result++;

			return result;
		}
	}
}
