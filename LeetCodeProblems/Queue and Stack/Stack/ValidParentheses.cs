using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Stack
{
	public class ValidParentheses
	{
		public bool IsValid(string s)
		{
			if (s == null || s.Length == 0)
				return true;

			Stack<char> openingBrackets = new Stack<char>();

			foreach (char c in s)
			{
				if (c == '(' || c == '[' || c == '{')
					openingBrackets.Push(c);
				else
				{
					if (openingBrackets.Count == 0)
						return false;
					if (openingBrackets.Pop() != _ConvertToOpeningBracket(c))
						return false;
				}
			}

			if (openingBrackets.Count > 0)
				return false;

			return true;
		}

		private char _ConvertToOpeningBracket(char closingBracket)
		{
			if (closingBracket == ')')
				return '(';
			if (closingBracket == ']')
				return '[';
			if (closingBracket == '}')
				return '{';

			return '-';
		}
	}
}
