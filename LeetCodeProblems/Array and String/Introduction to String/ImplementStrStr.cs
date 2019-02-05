using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Introduction_to_String
{
	public class ImplementStrStr
	{
		public int StrStr(string haystack, string needle)
		{
			int result = -1;

			if (haystack != null && needle != null && haystack.Length >= needle.Length)
			{
				if (needle.Length == 0)
					return 0;

				for (int i = 0; i < haystack.Length; i++)
				{
					bool equal = true;

					if (i + needle.Length - 1 >= haystack.Length)
						break;

					for (int j = 0; j < needle.Length && equal; j++)
					{
						if (haystack[i + j] != needle[j])
							equal = false;
					}

					if (equal)
					{
						result = i;
						break;
					}
				}
			}

			return result;
		}

		public int StrStr2(string haystack, string needle)
		{
			int result = -1;

			if (haystack != null && needle != null)
				result = haystack.IndexOf(needle);

			return result;
		}
	}
}
