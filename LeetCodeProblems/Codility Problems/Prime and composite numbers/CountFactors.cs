namespace LeetCodeProblems.Codility_Problems.Prime_and_composite_numbers
{
	public class CountFactors
	{
		public int solution(int N)
		{
			int result = 0;

			long i = 1;
			while (i * i < N)
			{
				if (N % i == 0)
					result += 2;

				i++;
			}

			if (i * i == N)
				result++;

			return result;
		}
	}
}
