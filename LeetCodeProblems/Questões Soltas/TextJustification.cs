using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Questões_Soltas
{
	public class TextJustification
	{
		public IList<string> FullJustify(string[] words, int maxWidth)
		{
			List<string> result = new List<string>();
			int index = 0;
			int currentLength = 0;

			while (index < words.Length)
			{
				for (int i = index; i < words.Length; i++)
				{
					if (currentLength + words[i].Length > maxWidth)
					{
						string[] justifiedWords = new string[i - index];
						Array.Copy(words, index, justifiedWords, 0, justifiedWords.Length);
						index = i;
						result.Add(_Justify(justifiedWords, maxWidth, currentLength - 1));
						currentLength = 0;
						break;
					}

					currentLength += words[i].Length + 1;

					if (i == words.Length - 1)
					{
						string[] justifiedWords = new string[i - index + 1];
						Array.Copy(words, index, justifiedWords, 0, justifiedWords.Length);
						index = i + 1;
						result.Add(_LeftJustify(justifiedWords, maxWidth));
						currentLength = 0;
					}
				}
			}

			return result;
		}

		private string _Justify(string[] words, int maxWidth, int currentLength)
		{
			if (words.Length == 1)
				return _LeftJustify(words, maxWidth);

			StringBuilder justifiedText = new StringBuilder();

			int spacesToAddText = maxWidth - currentLength;
			int spacesToAddWord = spacesToAddText / (words.Length - 1);
			int extraSpaces = spacesToAddText % (words.Length - 1);

			for (int i = 0; i < words.Length - 1; i++)
			{
				justifiedText.Append(words[i]);
				justifiedText.Append(" ");

				for (int j = 0; j < spacesToAddWord; j++)
					justifiedText.Append(" ");

				if (extraSpaces-- > 0)
					justifiedText.Append(" ");
			}

			justifiedText.Append(words[words.Length - 1]);

			return justifiedText.ToString();
		}

		private string _LeftJustify(string[] words, int maxWidth)
		{
			StringBuilder justifiedText = new StringBuilder();
			justifiedText.Append(words[0]);

			for (int i = 1; i < words.Length; i++)
			{
				justifiedText.Append(" ");
				justifiedText.Append(words[i]);
			}

			while (justifiedText.Length < maxWidth)
				justifiedText.Append(" ");

			return justifiedText.ToString();
		}
	}
}
