using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Conclusion
{
	public class ReverseWordsinaStringIII
	{
		public string ReverseWords(string s)
		{
			string result = null;

			if (s != null)
			{
				StringBuilder sb = new StringBuilder();

				string[] words = s.Split(new string[] { " " }, StringSplitOptions.None);

				for (int i = 0; i < words.Length; i++)
				{
					sb.Append(_ReverseString(words[i]));
					if (i < words.Length - 1)
						sb.Append(" ");
				}

				result = sb.ToString();
			}

			return result;
		}

		private string _ReverseString(string s)
		{
			string result = null;

			if (s != null)
			{
				int i = 0;
				int j = s.Length - 1;

				char[] chars = s.ToCharArray();

				while (i < j)
				{
					char temp = chars[i];
					chars[i] = chars[j];
					chars[j] = temp;
					i++;
					j--;
				}

				result = new string(chars);
			}

			return result;
		}
	}
}
