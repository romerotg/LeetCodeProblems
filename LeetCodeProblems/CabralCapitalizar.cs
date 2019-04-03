using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
	public class CabralCapitalizar
	{
		public string CapitalizeString(string s)
		{
			if (s == null || s.Length == 0)
				return s;

			StringBuilder sb = new StringBuilder();
			sb.Append(char.ToUpper(s[0]));

			bool shouldAddSpace = false;
			bool shouldCapitalize = false;

			for (int i = 1; i < s.Length; i++)
			{
				char c = s[i];
				if (c == ' ')
					shouldAddSpace = false;
				else
				{
					bool currShouldAddSpace = _ShouldAddSpace(c);
					if (shouldAddSpace && !currShouldAddSpace)
						sb.Append(' ');

					bool currShouldCapitalize = _ShouldCapitalize(c);
					if (shouldCapitalize && !currShouldCapitalize)
						c = char.ToUpper(c);

					shouldAddSpace = currShouldAddSpace;
					shouldCapitalize = currShouldCapitalize;
				}

				sb.Append(c);
			}

			return sb.ToString();
		}

		private bool _ShouldAddSpace(char c)
		{
			return c == '.' || c == ',' || c == ';' || c == '?' || c == '!';
		}

		private bool _ShouldCapitalize(char c)
		{
			return c == '.' || c == '?' || c == '!';
		}
	}
}
