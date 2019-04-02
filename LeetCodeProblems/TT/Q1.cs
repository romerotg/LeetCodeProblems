using System.Text;

namespace LeetCodeProblems.TT
{
	public class Q1
	{
		public string solution(string S, string T)
		{
			if (S.Length > T.Length || T.Length - S.Length > 1)
				return "IMPOSSIBLE";

			// EQUAL || SWAP || REPLACE
			if (S.Length == T.Length)
			{
				if (S == T)
					return "EQUAL";

				for (int i = 0; i < S.Length; i++)
				{
					if (S[i] != T[i])
					{
						char[] chars = T.ToCharArray();
						chars[i] = S[i];

						if (new string(chars) == S)
							return string.Format("REPLACE {0} {1}", S[i], T[i]);

						if (i < S.Length - 1)
						{
							chars = T.ToCharArray();
							char c = chars[i];
							chars[i] = chars[i + 1];
							chars[i + 1] = c;

							if (new string(chars) == S)
								return string.Format("SWAP {0} {1}", S[i], S[i + 1]);
						}
					}
				}
			}
			// INSERT
			else
			{
				StringBuilder sb = new StringBuilder(S);

				for (int i = 0; i < S.Length; i++)
				{
					if (S[i] != T[i])
					{
						sb.Insert(i, T[i]);

						if (sb.ToString() == T)
							return string.Format("INSERT {0}", T[i]);

						sb.Remove(i, 1);
					}
				}

				char lastChar = T[T.Length - 1];
				sb.Append(lastChar);
				if (sb.ToString() == T)
					return string.Format("INSERT {0}", lastChar);
			}

			return "IMPOSSIBLE";
		}
	}
}
