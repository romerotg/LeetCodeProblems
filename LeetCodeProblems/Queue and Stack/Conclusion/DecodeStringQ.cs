using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Queue_and_Stack.Conclusion
{
	public class DecodeStringQ
	{
		public string DecodeString(string s)
		{
			if (s == null)
				return null;

			Stack<int> bracketMultipliers = new Stack<int>();
			StringBuilder numberBuilder = new StringBuilder();

			Stack<StringBuilder> bracketStringBuilders = new Stack<StringBuilder>();
			StringBuilder currentStringBuilder = new StringBuilder();

			StringBuilder decoded = new StringBuilder();

			foreach (char c in s)
			{
				if (c == '[')
				{
					bracketMultipliers.Push(int.Parse(numberBuilder.ToString()));
					numberBuilder.Clear();

					if (currentStringBuilder != null)
						bracketStringBuilders.Push(currentStringBuilder);

					currentStringBuilder = new StringBuilder();
				}
				else if (c == ']')
				{
					int multiplier = bracketMultipliers.Pop();

					if (bracketMultipliers.Count == 0)
					{
						for (int i = 0; i < multiplier; i++)
							decoded.Append(currentStringBuilder);

						currentStringBuilder = null;
					}
					else
					{
						StringBuilder sb = bracketStringBuilders.Pop();

						for (int i = 0; i < multiplier; i++)
							sb.Append(currentStringBuilder);

						currentStringBuilder = sb;
					}
				}
				else if (char.IsNumber(c))
				{
					if (currentStringBuilder != null && bracketMultipliers.Count == 0)
					{
						decoded.Append(currentStringBuilder);
						currentStringBuilder = null;
					}
					numberBuilder.Append(c);
				}
				else
				{
					if (currentStringBuilder == null)
						currentStringBuilder = new StringBuilder();

					currentStringBuilder.Append(c);
				}
			}

			if (currentStringBuilder != null)
				decoded.Append(currentStringBuilder);

			return decoded.ToString();
		}
	}
}
