namespace LeetCodeProblems.Codility_Problems.Stacks_and_Queues
{
	public class Nesting
	{
		public int solution(string S)
		{
			if (S == null || S.Length == 0)
				return 1;

			int stackCount = 0;

			foreach (char s in S)
			{
				if (s == '(')
					stackCount++;
				else
				{
					if (stackCount == 0)
						return 0;
					stackCount--;
				}
			}

			return stackCount > 0 ? 0 : 1;
		}
	}
}
