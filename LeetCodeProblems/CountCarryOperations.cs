namespace LeetCodeProblems
{
	public class CountCarryOperations
	{
		public int solution(int A, int B)
		{
			int a = A;
			int b = B;
			int carry = 0;
			int result = 0;

			while (a > 0 || b > 0)
			{
				int sum = (a % 10) + (b % 10) + carry;
				carry = sum / 10;
				a /= 10;
				b /= 10;

				if (carry > 0)
					result++;
			}

			return result;
		}
	}
}
