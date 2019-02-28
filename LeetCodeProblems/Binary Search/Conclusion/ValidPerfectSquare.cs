namespace LeetCodeProblems.Binary_Search.Conclusion
{
	public class ValidPerfectSquare
	{
		public bool IsPerfectSquare(int num)
		{
			if (num <= 0)
				return false;
			if (num == 1)
				return true;

			long left = 1;
			long right = num / 2;

			while (left <= right)
			{
				long middle = left + (right - left) / 2;
				long power = middle * middle;

				if (power == num)
					return true;

				if (power < num)
					left = middle + 1;
				else
					right = middle - 1;
			}

			return false;
		}
	}
}
