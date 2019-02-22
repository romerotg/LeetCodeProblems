namespace LeetCodeProblems.Binary_Search.TemplateI
{
	public class SqrtX
	{
		public int MySqrt(int x)
		{
			if (x == 0)
				return 0;

			int left = 0;
			int right = x;

			while (left <= right)
			{
				int middle = left + (right - left) / 2;

				if (middle > x / middle)
					right = middle - 1;
				else
				{
					if (middle + 1 > x / (middle + 1))
						return middle;
					else
						left = middle + 1;
				}
			}

			return -1;
		}
	}
}
