namespace LeetCodeProblems.Codility_Problems.Euclidean_algorithm
{
	public class ChocolatesByNumbers
	{
		public int solution(int N, int M)
		{
			int biggest = N > M ? N : M;
			int lowest = N + M - biggest;
			return N / _MDC(biggest, lowest);
		}

		private int _MDC(int a, int b)
		{
			if (a % b == 0)
				return b;
			else
				return _MDC(b, a % b);
		}
	}
}
