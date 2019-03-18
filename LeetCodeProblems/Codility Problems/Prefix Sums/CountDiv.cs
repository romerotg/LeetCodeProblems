namespace LeetCodeProblems.Codility_Problems.Prefix_Sums
{
	public class CountDiv
	{
		public int solution(int A, int B, int K)
		{
			int firstDivisible = A % K == 0 ? A : A + (K - A % K);

			if (firstDivisible > B)
				return 0;

			return ((B - firstDivisible) / K) + 1;
		}
	}
}
