namespace LeetCodeProblems.Codility_Problems.Greedy_algorithms
{
	public class TieRopes
	{
		public int solution(int K, int[] A)
		{
			int currentRope = 0;
			int count = 0;

			for (int i = 0; i < A.Length; i++)
			{
				currentRope += A[i];

				if (currentRope >= K)
				{
					currentRope = 0;
					count++;
				}
			}

			return count;
		}
	}
}
