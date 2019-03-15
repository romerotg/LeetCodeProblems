namespace LeetCodeProblems.Codility_Problems.Counting_Elements
{
	public class MissingInteger
	{
		public int solution(int[] A)
		{
			bool[] exists = new bool[A.Length];

			foreach (int num in A)
			{
				if (num > 0 && num < exists.Length + 1)
					exists[num - 1] = true;
			}

			for (int i = 0; i < exists.Length; i++)
				if (!exists[i])
					return i + 1;

			return exists.Length + 1;
		}
	}
}
