namespace LeetCodeProblems.Codility_Problems.Prime_and_composite_numbers
{
	public class MinPerimeterRectangle
	{
		public int solution(int N)
		{
			int biggestDivisor = 1;

			int i = 1;
			while (i * i <= N)
			{
				if (N % i == 0)
					biggestDivisor = i;
				i++;
			}

			return 2 * (biggestDivisor + N / biggestDivisor);
		}
	}
}
