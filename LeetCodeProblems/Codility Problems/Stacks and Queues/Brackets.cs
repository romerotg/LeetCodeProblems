using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Stacks_and_Queues
{
	public class Brackets
	{
		public int solution(string S)
		{
			if (S == null || S.Length == 0)
				return 1;

			Stack<char> stack = new Stack<char>();

			foreach (char s in S)
			{
				if (s == '{' || s == '[' || s == '(')
					stack.Push(s);
				else
				{
					if (stack.Count == 0 || stack.Pop() != _GetOpeningBracket(s))
						return 0;
				}
			}

			return stack.Count > 0 ? 0 : 1;
		}

		private char _GetOpeningBracket(char c)
		{
			switch (c)
			{
				case '}':
					return '{';
				case ']':
					return '[';
				case ')':
					return '(';
				default:
					return '-';
			}
		}
	}
}
