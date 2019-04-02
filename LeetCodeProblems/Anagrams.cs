using System;
using System.Collections.Generic;
using System.IO;

namespace LeetCodeProblems
{
	public class Anagrams
	{
		public List<string> GetAnagrams(string w)
		{
			List<string> result = new List<string>();

			char[] chars = w.ToCharArray();
			Array.Sort(chars);
			string ordered = new string(chars);

			string[] words = File.ReadAllLines(@"D:\Workspace\LeetCodeProblems\LeetCodeProblems\palavrinhas.txt");

			for (int i = 0; i < words.Length; i++)
			{
				char[] currentChars = words[i].ToCharArray();
				Array.Sort(currentChars);
				if (ordered == new string(currentChars))
					result.Add(words[i]);
			}

			return result;
		}
	}
}
