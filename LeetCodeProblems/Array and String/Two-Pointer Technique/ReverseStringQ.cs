using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Two_Pointer_Technique
{
	public class ReverseStringQ
	{
		public void ReverseString(char[] s)
		{
			if (s != null && s.Length > 1)
			{
				int start = 0;
				int end = s.Length - 1;

				while (start < end)
				{
					char c = s[start];
					s[start] = s[end];
					s[end] = c;
					start++;
					end--;
				}
			}
		}
	}
}
