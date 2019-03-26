namespace LeetCodeProblems.Codility_Problems.Greedy_algorithms
{
	public class MaxNonoverlappingSegments
	{
		public int solution(int[] A, int[] B)
		{
			if (A == null || A.Length == 0)
				return 0;

			int count = 1;
			int previousEnd = B[0];

			for (int i = 1; i < A.Length; i++)
			{
				if (A[i] > previousEnd)
				{
					count++;
					previousEnd = B[i];
				}
			}

			return count;
		}
	}
}
