using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Introduction_to_String
{
	public class LongestCommonPrefixQ
	{
		public string LongestCommonPrefix(string[] strs)
		{
			string result = "";

			if (strs != null && strs.Length > 0)
			{
				result = strs[0];

				if (strs.Length > 1)
				{
					for (int i = 1; i < strs.Length; i++)
					{
						if (result.Length == 0)
							break;

						for (int j = 0; j < result.Length; j++)
						{
							if (j >= strs[i].Length)
								break;

							if (result[j] != strs[i][j])
							{
								result = result.Substring(0, j);
								break;
							}
						}

						if (result.Length > strs[i].Length)
							result = result.Substring(0, strs[i].Length);
					}
				}
			}

			return result;
		}
	}
}
