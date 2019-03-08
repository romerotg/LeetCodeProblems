namespace LeetCodeProblems.Recursion_I.Principle_of_Recursion
{
	public class ReverseStringQ
	{
		public void ReverseString(char[] s)
		{
			if (s == null || s.Length == 0)
				return;

			_ReverseString(s, 0, s.Length - 1);
		}

		private void _ReverseString(char[] s, int i, int j)
		{
			if (i >= j)
				return;

			char c = s[i];
			s[i] = s[j];
			s[j] = c;
			_ReverseString(s, i + 1, j - 1);
		}
	}
}
