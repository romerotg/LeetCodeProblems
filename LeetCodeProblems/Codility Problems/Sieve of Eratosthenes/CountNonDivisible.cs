namespace LeetCodeProblems.Codility_Problems.Sieve_of_Eratosthenes
{
	public class CountNonDivisible
	{
		public int[] solution(int[] A)
		{
			int[] result = new int[A.Length];

			if (A.Length == 1)
				return result;

			for (int i = 0; i < A.Length; i++)
			{
				for (int j = i + 1; j < A.Length; j++)
				{
					if (A[i] % A[j] != 0)
						result[i]++;
					if (A[j] % A[i] != 0)
						result[j]++;
				}
			}

			return result;
		}
	}
}
