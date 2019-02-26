namespace LeetCodeProblems.Binary_Search.TemplateII
{
	public class FirstBadVersion
	{
		public int firstBadVersion(int n)
		{
			if (n == 0)
				return -1;

			int left = 1;
			int right = n;
			int firstBadVersion = int.MaxValue;

			while (left <= right)
			{
				int middle = left + (right - left) / 2;

				if (isBadVersion(middle))
				{
					firstBadVersion = middle;
					right = middle - 1;
				}
				else
					left = middle + 1;
			}

			return firstBadVersion;
		}

		private bool isBadVersion(int n)
		{
			if (n >= 4)
				return true;

			return false;
		}
	}
}
