namespace LeetCodeProblems.Codility_Problems.Arrays
{
	public class CyclicRotation
	{
		public int[] solution(int[] A, int K)
		{
			if (A.Length == 0 || K == 0 || K == A.Length)
				return A;

			int[] result = new int[A.Length];

			for (int i = 0; i < A.Length; i++)
				result[(i + K) % A.Length] = A[i];

			return result;
		}
	}
}
