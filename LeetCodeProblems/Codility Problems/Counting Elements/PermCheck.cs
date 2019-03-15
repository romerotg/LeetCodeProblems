namespace LeetCodeProblems.Codility_Problems.Counting_Elements
{
	public class PermCheck
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length == 0)
				return 0;

			int[] count = new int[A.Length];

			foreach (int num in A)
			{
				if (num - 1 >= count.Length || count[num - 1] > 0)
					return 0;
				else
					count[num - 1] = 1;
			}

			return 1;
		}
	}
}
