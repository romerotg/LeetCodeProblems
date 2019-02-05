using System;
using System.Text;

namespace LeetCodeProblems.Array_and_String.Conclusion
{
	public class ReverseWordsinaString
	{
		public string ReverseWords(string s)
		{
			string result = null;

			if (s != null)
			{
				string[] words = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
				StringBuilder sb = new StringBuilder();
				for (int i = words.Length - 1; i >= 0; i--)
				{
					sb.Append(words[i]);
					if (i > 0)
						sb.Append(" ");
				}

				result = sb.ToString();
			}

			return result;
		}

		public string ReverseWords2(string s)
		{
			string result = null;

			if (s != null)
			{
				StringBuilder phrase = new StringBuilder();

				StringBuilder word = new StringBuilder();
				bool readingWord = false;

				for (int i = 0; i < s.Length; i++)
				{
					if (s[i] == ' ')
					{
						if (readingWord)
						{
							readingWord = false;
							phrase.Insert(0, word);
							phrase.Insert(0, " ");
							word.Clear();
						}
					}
					else
					{
						readingWord = true;
						word.Append(s[i]);
					}
				}

				if (readingWord)
					phrase.Insert(0, word.ToString());
				else if (phrase.Length > 0)
					phrase.Remove(0, 1);

				result = phrase.ToString();
			}

			return result;
		}
	}
}
